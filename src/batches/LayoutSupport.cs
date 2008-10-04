using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every window command entry stays within the limit.</summary>
        public static bool CheckWindowCommandRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double scale = weight * 9.2;
            if (scale < (span - span))
            {
                scale = scale - (double)336;
            }
            else
            {
                scale = scale + (span * 3.52);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)1) + (double)(long)i;
            }
            return scale - (span - 7.13);
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Synced,
            Failed,
        }
    }
}
