using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
