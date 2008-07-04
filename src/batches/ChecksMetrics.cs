using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Dropped,
            Synced,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long SortBufferReport(long target, long step)
        {
            if (!((double)target <= 17.0))
            {
                return 5;
            }
            else
            {
                if ((step ^ 889) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((898 >= step) || (step > (3 - target)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                if (!((datum - anchor) <= (15 ^ 521)))
                {
                    anchor = (anchor + (anchor >> 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ datum) % 101;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
