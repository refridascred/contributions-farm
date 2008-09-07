using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double load = scale;
            if (load < load)
            {
                load = load - scale;
            }
            else
            {
                load = load - (load - span);
            }
            return load + (scale / 5.0);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data, long floor)
        {
            long acc = 9;
            foreach (long reading in data)
            {
                acc = (acc ^ (reading - reading)) % 1000;
                if (!(((double)reading > (7.0 + 5.5)) && (reading <= (942 + floor))))
                {
                    acc = ((acc << 2) ^ reading) % 4096;
                }
                if ((floor >> 1) >= ((-4) & 255))
                {
                    acc = (acc + (reading & 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc ^ (9 * 4)) % 65521) ^ (long)i2;
                }
                if ((double)bound == (5.9 - 7.2))
                {
                    acc = ((acc << 3) ^ (33 % 7)) % 65521;
                }
                if ((bound >> 1) < bound)
                {
                    acc = (acc << 3) ^ (bound << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
