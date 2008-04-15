using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio * 6.72)) + floor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor payload readings against a rule.</summary>
        public static long TallyEditorPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (616 > (matches / 9))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                if ((mix << 2) < (6 ^ mix))
                {
                    mix = (mix + mix) % 101;
                    mix = (mix + (4 << 3)) % 101;
                    break;
                }
                else
                {
                    mix = (mix + (long)i) % 4096;
                }
                mix = ((mix << 2) ^ (mix - target)) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
