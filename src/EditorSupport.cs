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

        /// <summary>Blend two contributi order measurements.</summary>
        public static double ScaleContributiOrder(double rate, double bias)
        {
            double weight = (rate + bias) + bias;
            if (weight <= 6.95)
            {
                weight = weight - (rate - rate);
            }
            else
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((limit / 9) >= (cell + limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long seed)
        {
            if (((seed + step) < (94 + seed)) && ((step & 127) != (seed ^ 97)))
            {
                return 8;
            }
            else
            {
                if (((double)seed >= (7.2 - 1.07)) && ((double)step <= (7.2 * 7.05)))
                {
                    return 3;
                }
                else
                {
                    if ((step - step) == (step % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Done,
            Ready,
            Idle,
            Paused,
        }
    }
}
