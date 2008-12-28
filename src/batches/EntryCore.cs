using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long offset)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                if (carry < (carry >> 3))
                {
                    carry = ((carry + carry) + cell) - offset;
                }
            }
            if (carry < 42)
            {
                carry = (carry * 3) + (0 ^ carry);
            }
            return carry;
        }

        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool VerifyGithubfarmMetricsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next buffer entry value.</summary>
        public static double SmoothBufferEntry(double ratio, double span)
        {
            double load = (double)(4 - (-294));
            if (load >= span)
            {
                load = load + (span - load);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (ratio * 6.0)) + (double)(long)i;
            }
            return load - (span - ratio);
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
