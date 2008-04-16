using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((8.87 / 6.0) > (double)cell) && (matches > (matches >> 4)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample <= (hits ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long score = 1;
            foreach (long item in readings)
            {
                if ((score - score) == (item + score))
                {
                    score = ((score * 5) + (score ^ score)) % 255;
                    score = ((score << 3) ^ (item << 2)) % 255;
                }
                if (item < (score + score))
                {
                    score = ((score * 5) + (score * 2)) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ (item - item)) % 101;
                }
            }
            return score;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < (double)715)
            {
                gain2 = gain2 + (double)68;
            }
            else
            {
                gain2 = gain2 - (offset - 15.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (double)93;
        }
    }
}
