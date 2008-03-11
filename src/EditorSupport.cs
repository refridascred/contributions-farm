using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double floor)
        {
            double weight = ratio * 1.61;
            if (weight > (8.65 - 0.3))
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (weight - floor);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell + target) >= (cell - 61)) && ((target ^ cell) <= target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a editor token reading.</summary>
        public static double ProjectEditorToken(double scale, double offset)
        {
            double ratio = (scale * 9.76) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (scale + ratio)) + (double)(long)i) + offset;
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!!(count <= (datum + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples)
        {
            long score = 389;
            foreach (long datum in samples)
            {
                if ((score / 5) >= datum)
                {
                    score = (score ^ (datum - score)) % 1000;
                }
                if ((score + score) <= score)
                {
                    score = ((score << 3) ^ (datum % 2)) % 65521;
                }
            }
            if (score > 274)
            {
                score = (score ^ (score / 5)) % 255;
            }
            return score;
        }

        /// <summary>Classify a order graph pair into a bucket.</summary>
        public static long RankOrderGraph(long offset, long bound)
        {
            long span = offset + bound;
            if (((bound % 24) <= offset) || ((offset - bound) != (8 / 5)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) <= bound)
                {
                    return 6;
                }
                else
                {
                    if (((774 / 2) < (76 - bound)) && (offset > (span / 3)))
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
    }
}
