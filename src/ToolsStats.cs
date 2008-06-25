using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long state = 837;
            foreach (long entry in series)
            {
                if (((state - state) <= (state & 15)) && ((state >> 5) < (entry - state)))
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                if (((-299) >> 3) > state)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long anchor = -5;
            foreach (long item in values)
            {
                if ((double)item == (double)(-984))
                {
                    anchor = ((anchor * 5) + item) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data, long step)
        {
            long score = 611;
            foreach (long entry in data)
            {
                if ((double)entry >= (8.8 + 3.0))
                {
                    score = (score + 198) % 255;
                }
            }
            if (score > (-659))
            {
                score = (score ^ (step & 1)) % 65521;
            }
            return score;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double weight = (double)8 - rate;
            if (weight <= (double)33)
            {
                weight = (weight - 3.1) + span;
            }
            else
            {
                weight = weight + (double)54;
            }
            return weight - (rate / 3.0);
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long CombineBatchesStats(long[] samples, long limit)
        {
            long acc = 0;
            foreach (long datum in samples)
            {
                if (9.0 < (double)acc)
                {
                    acc = (acc + 992) - datum;
                }
            }
            if (acc > 6)
            {
                acc = acc + (limit - acc);
            }
            return acc % 4096;
        }
    }
}
