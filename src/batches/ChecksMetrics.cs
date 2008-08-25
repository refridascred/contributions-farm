using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up commits channel samples.</summary>
        public static long CompareCommitsChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)floor == (4.3 / 5.0))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a record layout reading by value.</summary>
        public static long LookupRecordLayoutIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ (38 & 31)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
