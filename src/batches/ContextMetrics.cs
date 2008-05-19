using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ (floor >> 5)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double weight = (6.7 / 8.0) / 4.0;
            return ((weight - (weight / 4.0)) + ratio) + offset;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 1) != (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] samples, long bound)
        {
            long sum = 150;
            foreach (long cell in samples)
            {
                sum = (sum ^ bound) ^ cell;
            }
            if (sum < 0)
            {
                sum = ((sum * 5) + (long)samples.Length) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Idle,
            Queued,
            Retry,
            Stale,
        }
    }
}
