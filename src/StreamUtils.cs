using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double scale, double offset)
        {
            double gain = offset;
            if (gain < (gain * 7.79))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - 1.9;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (scale * 5.2)) - (double)(long)i;
            }
            return gain - (double)6;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count > (count ^ entry)) && (((count << 2) >= entry) || ((count << 3) <= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Paused,
            Failed,
            Ready,
        }
    }
}
