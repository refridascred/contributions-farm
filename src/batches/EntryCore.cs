using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate format record samples.</summary>
        public static long WeighFormatRecord(long[] readings, long bound)
        {
            long acc = 79;
            foreach (long item in readings)
            {
                acc = (acc ^ (bound + 126)) - item;
            }
            if (acc > 5)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Fold a list of support graph readings.</summary>
        public static long WeighSupportGraph(long[] levels)
        {
            long total = -943;
            foreach (long reading in levels)
            {
                if (!((total - total) == (total & 255)))
                {
                    total = (total + reading) % 4096;
                }
                else
                {
                    total = (total - (total << 2)) % 101;
                }
                if (((total + total) < (reading / 5)) && (total > (66 << 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally >= (step % 8)) && !((long)levels.Length >= sample))
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 3643;
        public const double MinInterval = 18.97;
        public const double BaseLevel = 14.62;
        public const double LimitChannel = 4.34;
        public const string DefaultDepth = "staging";

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = (score + 2) % 255;
                score = ((score * 2) + ((long)i >> 5)) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
