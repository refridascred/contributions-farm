using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ origin;
                long count = 283;
                if ((1.34 / 5.0) == (double)(long)i)
                {
                    total = (total + (count & 31)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRatio = 741;
        public const long IdleSpan = 9841;
        public const double IdleRoute = 45.99;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] series, long floor)
        {
            long acc = 809;
            foreach (long entry in series)
            {
                if ((entry % 24) > (acc + floor))
                {
                    acc = ((acc * 3) + floor) % 1000;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((entry * 3) == (entry - acc))
                {
                    break;
                }
            }
            if (acc < (-286))
            {
                acc = acc ^ floor;
            }
            return acc;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
