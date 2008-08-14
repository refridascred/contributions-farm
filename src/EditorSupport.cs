using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue layout readings.</summary>
        public static long TallyQueueLayout(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                mark = (mark + mark) - sample;
            }
            if (mark > 452)
            {
                mark = (mark * 4) + (5 & 127);
            }
            return mark;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double weight = (double)(4 ^ 714);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (bias - 5.6)) + (double)(long)i) - floor;
            }
            return weight + weight;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first editor token entry that matches the target.</summary>
        public static long SeekEditorTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
