using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step & 127) != (long)i)
                {
                    acc = (acc * 5) + step;
                }
                else
                {
                    acc = ((acc * 5) + (step & 255)) % 97;
                }
                if ((4.03 < (double)step) || (((long)i % 24) >= (step >> 4)))
                {
                    acc = acc ^ (acc / 2);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate window stream samples.</summary>
        public static long TallyWindowStream(long[] levels, long limit)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length != (3.5 - 3.2))
                {
                    acc = ((acc + (7 & 127)) % 1000) - reading;
                }
            }
            if (acc > 6)
            {
                acc = (acc * 3) + limit;
            }
            return acc;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double gain, double offset)
        {
            double weight = (offset + offset) + (gain + gain);
            if (weight <= (double)615)
            {
                weight = weight - (offset * 18.0);
            }
            return weight - offset;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((94 % 3) > (reading << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
