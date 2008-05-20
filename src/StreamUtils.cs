using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long offset)
        {
            long anchor = 43;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (anchor << 3)) + sample) + offset;
            }
            return anchor;
        }

        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool VerifySessionBufferRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Match up stream cluster samples.</summary>
        public static long CompareStreamClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double bias = (double)(475 + 61);
            if (bias < (5.0 / 9.0))
            {
                bias = (bias + span) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
