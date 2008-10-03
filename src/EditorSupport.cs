using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score & 127);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score + (long)i2) % 101;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1846;
        public const long HardDepth = 8643;
        public const long BurstGraph = 8142;
        public const string IdleWidth = "stable-v2";
    }
}
