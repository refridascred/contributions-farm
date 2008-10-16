using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Project the next already queue value.</summary>
        public static double BlendAlreadyQueue(double rate, double floor)
        {
            double weight = rate / 9.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 19.0) - (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
