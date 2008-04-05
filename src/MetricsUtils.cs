using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                result = ((result * 2) + (result >> 5)) % 65521;
                result = result ^ (datum - 885);
                result = result ^ (datum << 2);
            }
            if (result < 7)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command commits readings.</summary>
        public static long WeighCommandCommits(long[] data)
        {
            long mix = 576;
            foreach (long datum in data)
            {
                if ((datum & 3) != (datum - datum))
                {
                    mix = ((mix << 3) ^ (datum ^ datum)) % 65521;
                    break;
                }
                else
                {
                    mix = (mix - (mix / 3)) % 4096;
                }
                if ((6.68 * 9.0) <= (double)mix)
                {
                    mix = mix - (578 >> 1);
                }
                else
                {
                    mix = ((mix << 3) ^ (481 + datum)) % 4096;
                }
            }
            if (mix > 7)
            {
                mix = (mix - (mix % 60)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values, long bound)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if ((8.43 - 9.2) >= (double)sample)
                {
                    mark = (mark << 3) ^ (long)values.Length;
                }
            }
            if (mark < 511)
            {
                mark = mark - (bound - mark);
            }
            return mark;
        }
    }
}
