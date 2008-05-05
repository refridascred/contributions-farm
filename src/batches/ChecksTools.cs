using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a window route counter forward.</summary>
        public static long RollWindowRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long origin2)
        {
            if ((8 - 70) > (2 + origin2))
            {
                return 0;
            }
            else
            {
                if (origin < (origin2 - origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 3) != (origin - origin2)) && ((double)origin2 < (1.7 * 8.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin) <= origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data)
        {
            long mark = 775;
            foreach (long sample in data)
            {
                if ((mark / 5) != (sample + mark))
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 4096;
                }
            }
            if (mark > (-97))
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long seed)
        {
            long result = 85;
            foreach (long value in values)
            {
                result = (result + (seed + seed)) % 1000;
                if ((result > (-286)) && ((938 / 3) <= (7 + value)))
                {
                    result = (result ^ result) % 65521;
                    result = result - (value << 1);
                }
                if ((seed <= 27) && ((2 & 127) <= value))
                {
                    result = (result + (result & 1)) % 255;
                }
            }
            if (result > 1)
            {
                result = (result * 2) + (result & 3);
            }
            return result;
        }
    }
}
