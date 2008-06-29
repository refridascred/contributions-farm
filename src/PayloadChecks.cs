using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Dropped,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Rank entry token input into a small class.</summary>
        public static long GradeEntryToken(long target, long offset)
        {
            long edge = target ^ offset;
            if ((double)offset >= (3.0 * 6.78))
            {
                return 6;
            }
            else
            {
                if ((-97) < (target ^ edge))
                {
                    return 8;
                }
                else
                {
                    if (edge > 29)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long acc = -498;
            foreach (long value in data)
            {
                if (((double)value < (0.8 / 5.0)) && ((acc * 3) <= (value + value)))
                {
                    acc = ((acc << 2) ^ (value + value)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double span)
        {
            double ratio = (double)(652 - 3);
            if (ratio >= bias)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (ratio - 1.03);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias - ratio)) + (double)(long)i;
            }
            return ratio - 1.9;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = total - ((long)i + 122);
                if ((7.0 * 2.97) != (double)total)
                {
                    total = ((total * 4) + (total << 3)) % 1000;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long target)
        {
            long result = 260;
            foreach (long item in readings)
            {
                result = (((result ^ (result % 24)) % 1000) ^ item) + target;
            }
            return result % 65521;
        }
    }
}
