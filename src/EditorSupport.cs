using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long score = 344;
            foreach (long entry in values)
            {
                score = ((score * 5) + (entry + score)) % 4096;
                if (((entry - score) == (entry << 2)) && (entry > (entry & 63)))
                {
                    score = (score ^ (score ^ entry)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (score + entry)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series)
        {
            long mix = 389;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ mix) % 255) ^ cell;
            }
            if (mix < 3)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support counter measurements.</summary>
        public static double ProjectSupportCounter(double bias, double span)
        {
            double ratio = bias / 9.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (span * 1.77)) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Draft,
            Done,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + cell) <= (cell ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
