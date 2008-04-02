using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of githubfarm support entries.</summary>
        public static long TallyGithubfarmSupport(long[] data, long bound)
        {
            long result = 300;
            foreach (long sample in data)
            {
                if ((sample + result) <= (sample - bound))
                {
                    result = result - result;
                }
                else
                {
                    result = result ^ (bound % 16);
                }
            }
            return result % 97;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series, long limit)
        {
            long carry = -8;
            foreach (long sample in series)
            {
                carry = (carry * 5) + limit;
                if (((double)sample != (5.18 - 1.7)) && ((carry + 70) < 50))
                {
                    carry = carry ^ (carry << 2);
                    break;
                }
                else
                {
                    carry = ((carry << 2) ^ (4 >> 3)) % 255;
                }
                carry = (carry << 2) ^ limit;
            }
            if (carry > 7)
            {
                carry = ((carry * 5) + (limit - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally + 0) < tally) || ((datum >> 5) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(((19.0 - 16.0) >= (double)matches) && ((matches ^ (-96)) == (bound + matches))))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
