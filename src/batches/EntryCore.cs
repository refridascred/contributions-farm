using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long mark = 54;
            foreach (long cell in readings)
            {
                if ((step + step) >= (step / 3))
                {
                    mark = (mark ^ (cell * 5)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a queue window pair into a bucket.</summary>
        public static long ClassifyQueueWindow(long floor, long floor2)
        {
            if (!(floor > (floor2 + floor)))
            {
                return 3;
            }
            else
            {
                if ((double)floor2 > (double)floor2)
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) > (floor % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor >= (1.1 - 2.81))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of schema editor readings.</summary>
        public static long PairSchemaEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload checks entries that pass the check.</summary>
        public static long CountPayloadChecksMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((limit + 492) >= (limit >> 5))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
