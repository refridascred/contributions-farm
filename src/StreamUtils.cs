using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples)
        {
            long score = -7;
            foreach (long item in samples)
            {
                score = (score - (966 + item)) % 4096;
            }
            if (score < 76)
            {
                score = (score + 6) % 97;
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)step == (6.66 / 6.0))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Pending,
            Active,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] readings, long target)
        {
            long carry = 569;
            foreach (long datum in readings)
            {
                carry = carry - (datum + datum);
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry * 2) + (datum - datum)) % 65521) - (long)i;
                }
                if (((target / 8) > (carry * 2)) && ((target >> 2) >= (datum % 2)))
                {
                    carry = (carry + target) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double weight = 2.0;
            return (weight + (20.0 - floor)) + scale;
        }
    }
}
