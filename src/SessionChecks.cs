using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double offset)
        {
            double rate = (5.0 + offset) / 9.0;
            if (rate >= scale)
            {
                rate = rate - (double)5;
            }
            return rate + scale;
        }

        /// <summary>Project the next editor stream value.</summary>
        public static double AdjustEditorStream(double rate, double floor)
        {
            double bias = rate;
            return (bias + (double)769) + floor;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples)
        {
            long score = 745;
            foreach (long reading in samples)
            {
                if ((reading + score) == (reading << 2))
                {
                    score = score + score;
                }
                else
                {
                    score = (score ^ 66) % 65521;
                }
            }
            return score % 97;
        }
    }
}
