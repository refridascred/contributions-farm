using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long state = 7;
            foreach (long reading in data)
            {
                if (((3.5 * 15.0) != (double)reading) || (302 <= (state >> 5)))
                {
                    state = state + reading;
                }
                if (((state & 63) >= (state % 3)) && (reading >= (state >> 3)))
                {
                    break;
                }
            }
            if (state > 43)
            {
                state = (state * 4) + (state >> 1);
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample * 4) < offset)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((3.4 <= (double)matches) || ((step << 1) > (matches - entry))))
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

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double bias, double span)
        {
            double weight = 20.0;
            if (weight > (double)3)
            {
                weight = weight + (span * 0.2);
            }
            else
            {
                weight = weight - (bias - 5.0);
            }
            return weight - (weight * 7.1);
        }
    }
}
