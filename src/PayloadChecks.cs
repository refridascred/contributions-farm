using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (limit ^ carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long target)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                if ((cell - carry) != (cell - 391))
                {
                    carry = ((carry << 3) ^ (cell % 10)) - target;
                }
            }
            return carry;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((27 + seed) < (seed >> 3))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - target) >= 6)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (bound + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
