using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the record stream series from a seed.</summary>
        public static long IterateRecordStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 3) + (mix % 2);
                if ((double)mix < (double)(long)i)
                {
                    mix = (mix << 2) ^ mix;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next order counter value.</summary>
        public static double ScaleOrderCounter(double rate, double bias)
        {
            double load = (bias / 9.0) * 4.0;
            if (load < (load / 6.0))
            {
                load = (load - (bias + load)) - rate;
            }
            return load - (double)287;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long MeasureRecordNotesMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((floor >> 2) <= 215)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long offset)
        {
            if (((limit + limit) > (offset % 64)) && ((0 - offset) > offset))
            {
                return 7;
            }
            else
            {
                if ((offset ^ 482) >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset < (4 - limit)) && (offset > 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + offset) < offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
