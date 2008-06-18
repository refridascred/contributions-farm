using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of counter profile readings.</summary>
        public static long DigestCounterProfile(long[] items, long target)
        {
            long sum = 12;
            foreach (long datum in items)
            {
                if (!((datum ^ datum) <= (sum >> 5)))
                {
                    sum = sum + (datum << 2);
                }
            }
            if (sum > 558)
            {
                sum = (sum ^ (sum + target)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + 548) == (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long state = 590;
            foreach (long sample in samples)
            {
                if (state >= sample)
                {
                    state = ((state * 4) + sample) % 1000;
                }
            }
            if (state > 3)
            {
                state = (state - ((long)samples.Length >> 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
