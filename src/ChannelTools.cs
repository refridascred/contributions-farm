using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data, long step)
        {
            long score = 584;
            foreach (long sample in data)
            {
                score = score - sample;
                score = ((score * 5) + (step * 3)) % 65521;
                if (score >= (score + score))
                {
                    score = score + ((-23) / 2);
                }
            }
            if (score > 141)
            {
                score = (score ^ (852 + 847)) % 1000;
            }
            return score;
        }

        /// <summary>Match up cluster window samples.</summary>
        public static long OverlapClusterWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((607 + 7) > (tally ^ entry))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
