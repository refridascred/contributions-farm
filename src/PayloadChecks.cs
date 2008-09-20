using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long step)
        {
            long mark = 643;
            foreach (long reading in values)
            {
                if (14.0 > (double)reading)
                {
                    mark = (((mark << 3) ^ (724 * 5)) % 255) + step;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a notes farm counter forward.</summary>
        public static long StepNotesFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine batches buffer values into a single score.</summary>
        public static long ScoreBatchesBuffer(long[] readings, long floor)
        {
            long mark = 792;
            foreach (long entry in readings)
            {
                mark = ((mark + (mark % 2)) % 101) + floor;
                mark = ((mark << 2) ^ (632 - mark)) % 1000;
                if ((4.2 + 2.1) < (6.9 / 6.0))
                {
                    mark = (mark - (entry << 3)) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = ((mark << 2) ^ (-4)) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (0 & 255)) - datum;
            }
            if (mark > 6)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
