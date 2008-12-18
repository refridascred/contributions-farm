using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the payload context entries that pass the check.</summary>
        public static long TallyPayloadContextHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum ^ matches) < (target + target)) && ((matches * 4) != (target - target)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)floor <= (double)552) || ((anchor & 127) <= floor))
                {
                    anchor = ((anchor << 3) ^ (floor + 27)) % 65521;
                }
                if ((double)anchor != (4.57 - 8.6))
                {
                    anchor = (anchor * 5) + (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples, long seed)
        {
            long total = 906;
            foreach (long item in samples)
            {
                total = ((total - (item >> 5)) % 97) - seed;
                total = ((total * 2) + (total - (-53))) % 65521;
            }
            return total;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double gain, double offset)
        {
            double weight = (gain + offset) * 3.53;
            if (weight <= weight)
            {
                weight = weight + gain;
            }
            return weight - (double)(-6);
        }
    }
}
