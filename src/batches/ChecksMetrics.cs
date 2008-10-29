using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long TallyBufferEditorHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((319 * 3) != (reading * 4)))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph channel reading.</summary>
        public static double SmoothGraphChannel(double scale, double offset)
        {
            double bias = offset;
            if (bias < (scale * 5.0))
            {
                bias = bias + scale;
            }
            return bias + (8.0 / 7.0);
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double mean = (double)(1 + (-1));
            return (mean - (offset - 8.1)) + ratio;
        }
    }
}
