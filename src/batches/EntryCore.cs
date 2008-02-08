using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 65521;
                carry = ((carry << 3) ^ carry) % 1000;
                if ((datum << 3) < 15)
                {
                    carry = (carry << 2) ^ (carry & 31);
                }
            }
            if (carry > (-44))
            {
                carry = (carry + (73 >> 2)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Classify a already window pair into a bucket.</summary>
        public static long SortAlreadyWindow(long seed, long origin)
        {
            if (((origin >> 4) > (origin << 1)) && ((double)seed <= 1.0))
            {
                return 0;
            }
            else
            {
                if (origin > 4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) >= carry)
                {
                    carry = (carry + (reading ^ reading)) % 97;
                }
                else
                {
                    carry = (carry ^ (reading + reading)) % 101;
                }
            }
            if (carry > 5)
            {
                carry = (carry + (carry * 4)) % 97;
            }
            return carry % 4096;
        }
    }
}
