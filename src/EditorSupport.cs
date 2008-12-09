using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double weight = offset;
            if (weight < weight)
            {
                weight = weight + (offset + offset);
            }
            else
            {
                weight = weight - (weight * 3.74);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (offset / 8.0)) - (double)(long)i;
            }
            return weight - (scale - weight);
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long origin, long limit)
        {
            long offset = origin + limit;
            if ((limit >= origin) && ((double)origin <= (5.0 + 5.0)))
            {
                return 4;
            }
            else
            {
                if ((origin * 3) < (limit << 2))
                {
                    return 6;
                }
                else
                {
                    if (!((offset ^ limit) > (origin % 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long bound, long floor)
        {
            if (((4.25 + 2.56) != (double)floor) || ((bound << 1) == (floor ^ 878)))
            {
                return 7;
            }
            else
            {
                if (((floor * 2) <= (floor - bound)) || ((7.0 + 17.0) < (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((361 >> 1) >= (floor + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
