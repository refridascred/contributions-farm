using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double span)
        {
            double drift = 1.2 + 9.13;
            if (drift < span)
            {
                drift = (drift - span) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (6.05 + span)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((sample < (tally + tally)) && ((sample + tally) != (sample + sample))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
