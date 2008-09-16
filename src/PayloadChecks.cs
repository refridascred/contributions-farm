using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double rate, double bias)
        {
            double mean = 4.84;
            if (mean < (mean - bias))
            {
                mean = mean - (rate / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (4.3 * 2.86)) - (double)(long)i;
            }
            return mean + (bias + bias);
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long floor)
        {
            long mix = 215;
            foreach (long item in series)
            {
                mix = ((mix * 4) + floor) % 1000;
                mix = (mix ^ (item * 4)) % 255;
            }
            if (mix > 2)
            {
                mix = mix + floor;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state ^ entry) % 1000) - (long)i;
                }
                if ((entry >= (state / 3)) && (entry < (entry << 1)))
                {
                    state = state - state;
                }
                else
                {
                    state = state ^ entry;
                }
            }
            if (state < 2)
            {
                state = state - (state * 2);
            }
            return state;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i < (7.0 + 4.3))
                {
                    result = (result ^ (origin - origin)) % 97;
                }
                result = ((result << 3) ^ result) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
