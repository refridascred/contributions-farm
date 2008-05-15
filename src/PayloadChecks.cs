using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((6.57 + 4.78) > (double)value)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Queued,
            Synced,
            Failed,
            New,
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double weight = bias;
            if (weight >= (scale * 10.0))
            {
                weight = weight + (weight - scale);
            }
            else
            {
                weight = weight - 6.2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - (bias + 9.3);
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit layout profile readings against a rule.</summary>
        public static long TallyLayoutProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((0.2 * 6.08) == (double)seen) || (seen >= (entry - 6)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
