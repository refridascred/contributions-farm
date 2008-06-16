using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long mix = 231;
            foreach (long cell in items)
            {
                if (!(18.0 <= (double)mix))
                {
                    mix = ((mix * 5) + 88) - cell;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Roll a payload graph counter forward.</summary>
        public static long SeriesPayloadGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((8.8 / 9.0) >= (double)61)
                {
                    mark = mark ^ (94 >> 1);
                    break;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
