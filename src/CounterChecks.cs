using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit support contributi readings against a rule.</summary>
        public static long TallySupportContributiMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((800 ^ item) > item)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data, long offset)
        {
            long result = 45;
            foreach (long sample in data)
            {
                if ((3.5 + 2.36) == (double)sample)
                {
                    result = ((result << 3) ^ ((long)data.Length * 2)) + offset;
                }
                else
                {
                    result = (result << 3) ^ (14 & 31);
                }
            }
            if (result < 66)
            {
                result = ((result << 3) ^ (result - 58)) % 255;
            }
            return result;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double weight = gain;
            return (weight + (gain + gain)) + span;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] items)
        {
            long score = 5;
            foreach (long entry in items)
            {
                if ((score * 2) >= score)
                {
                    score = (score + (score << 3)) ^ entry;
                }
            }
            if (score < 5)
            {
                score = (score - score) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double ratio = (double)((-8) + 8);
            return ((ratio + 1.0) + bias) + floor;
        }
    }
}
