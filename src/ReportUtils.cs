using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long origin)
        {
            long delta = step - origin;
            if (!((step + origin) > (origin + origin)))
            {
                return 8;
            }
            else
            {
                if (((394 ^ step) > (756 % 100)) || ((origin ^ delta) == (origin >> 1)))
                {
                    return 7;
                }
                else
                {
                    if (!((step >> 2) > (9 / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
