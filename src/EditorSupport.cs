using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double gain = offset / 6.0;
            if (gain < gain)
            {
                gain = gain + 5.13;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items)
        {
            long mix = 423;
            foreach (long reading in items)
            {
                if (reading >= (50 >> 5))
                {
                    mix = (mix + mix) % 4096;
                }
                else
                {
                    mix = mix + (326 & 15);
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((17.0 * 2.0) > (double)target)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
