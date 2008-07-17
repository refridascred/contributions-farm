using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] readings)
        {
            long score = 224;
            foreach (long reading in readings)
            {
                if (((double)reading != (3.0 - 4.02)) && ((double)reading > 7.0))
                {
                    score = score + score;
                }
            }
            if (score > 275)
            {
                score = score - (score ^ score);
            }
            return score;
        }
    }
}
