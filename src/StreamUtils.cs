using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of counter editor readings.</summary>
        public static long FoldCounterEditor(long[] series, long target)
        {
            long mark = -7;
            foreach (long cell in series)
            {
                mark = ((mark << 2) ^ (target - cell)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Idle,
            Stale,
            New,
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double gain = (ratio + ratio) / 6.0;
            if (gain >= ratio)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain - (double)6;
            }
            return gain - 6.57;
        }
    }
}
