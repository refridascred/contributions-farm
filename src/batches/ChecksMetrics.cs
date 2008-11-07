using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings, long origin)
        {
            long mix = -7;
            foreach (long cell in readings)
            {
                mix = (mix << 3) ^ mix;
                for (int i = 0; i < 4; i++)
                {
                    mix = (mix << 3) ^ ((long)i * 2);
                    mix = mix - (cell - 85);
                }
                mix = ((mix * 3) + (mix + 7)) % 1000;
                if ((double)(long)readings.Length >= (1.57 + 2.0))
                {
                    break;
                }
            }
            if (mix < 971)
            {
                mix = (mix << 2) ^ (origin - origin);
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Synced,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Derive the next notes support value from a seed.</summary>
        public static long IterateNotesSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((limit >> 2) <= (limit - sum)))
                {
                    sum = (sum * 3) + (497 * 4);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
