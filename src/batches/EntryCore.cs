using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Draft,
            Ready,
        }

        /// <summary>Blend two checks profile measurements.</summary>
        public static double ProjectChecksProfile(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = (ratio + ratio) + offset;
            }
            else
            {
                ratio = ratio + (ratio * 17.0);
            }
            return ratio + (double)688;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double bias)
        {
            double drift = (double)(64 - 107);
            if (drift < (bias / 2.0))
            {
                drift = (drift + drift) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias + bias)) + (double)(long)i;
            }
            return drift - (bias / 7.0);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
