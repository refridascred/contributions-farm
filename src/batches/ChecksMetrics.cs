using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (state - limit)) % 1000;
                if ((state - state) <= limit)
                {
                    state = (state << 2) ^ state;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a queue layout figure with a bias.</summary>
        public static double ScaleQueueLayout(double rate, double offset)
        {
            double ratio = 1.1;
            if (ratio >= (double)4)
            {
                ratio = ratio - (offset + 2.46);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (4.0 - rate)) + (double)(long)i;
            }
            return ratio - (ratio / 7.0);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long offset)
        {
            long anchor = 359;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = anchor - ((long)i - item);
                }
                if (((offset << 2) == (item + offset)) || ((double)anchor <= 3.7))
                {
                    anchor = (anchor - (anchor << 1)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ offset) % 4096;
                }
            }
            return anchor % 1000;
        }
    }
}
