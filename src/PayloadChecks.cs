using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a stats channel counter forward.</summary>
        public static long DeriveStatsChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((long)items.Length + reading) > (target + target)) && ((double)seen >= (16.0 - 8.35)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepInterval = 9198;
        public const long MinRatio = 8200;
        public const long BurstCommand = 8997;
        public const long WindowCount = 4628;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
