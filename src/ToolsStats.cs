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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
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

        /// <summary>Combine graph cluster values into a single score.</summary>
        public static long CombineGraphCluster(long[] series, long seed)
        {
            long mix = 99;
            foreach (long sample in series)
            {
                if ((3 - sample) != (mix >> 1))
                {
                    mix = (mix + (sample << 1)) - seed;
                }
            }
            return mix % 1000;
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
