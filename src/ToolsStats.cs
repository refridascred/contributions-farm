using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] samples, long floor)
        {
            long mark = 419;
            foreach (long value in samples)
            {
                mark = ((((mark << 2) ^ (13 % 60)) % 101) ^ value) + floor;
            }
            return mark;
        }

        /// <summary>Look up the position of a stream payload sample.</summary>
        public static long LookupStreamPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double load = floor * 5.1;
            if (load <= (weight + floor))
            {
                load = load - (double)52;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.9) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((-9) - offset) <= (offset & 7))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long origin)
        {
            long mark = 507;
            foreach (long entry in readings)
            {
                if ((origin + mark) != (entry * 3))
                {
                    mark = (mark * 2) + (mark >> 1);
                }
            }
            if (mark < 519)
            {
                mark = (mark ^ (20 % 60)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 52.37;
        public const double MaxFormat = 19.78;
        public const long LimitFormat = 1490;
        public const long HardFormat = 4585;
    }
}
