using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) < entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                if (((double)datum > 14.0) || ((sum % 97) >= 73))
                {
                    sum = ((sum << 3) ^ (datum * 4)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values)
        {
            long carry = 5;
            foreach (long reading in values)
            {
                carry = carry - (reading & 63);
            }
            return carry;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm payload readings.</summary>
        public static long CombineGithubfarmPayload(long[] readings)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                if (!((95 - 991) >= sample))
                {
                    mark = (mark ^ (mark / 5)) % 101;
                }
                if ((25 + mark) < (mark & 31))
                {
                    break;
                }
            }
            if (mark > 27)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
