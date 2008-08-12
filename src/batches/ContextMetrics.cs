using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next route format value from a seed.</summary>
        public static long StepRouteFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if (((step & 3) <= step) && ((mix / 8) == (mix << 1)))
                {
                    mix = ((mix << 3) ^ (step & 127)) % 255;
                }
                if (!(403 <= (mix ^ step)))
                {
                    mix = mix ^ (mix % 60);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long carry = 9;
            foreach (long item in data)
            {
                carry = (carry - (carry >> 4)) % 255;
                carry = (carry + (carry >> 5)) % 101;
                if ((seed << 1) <= carry)
                {
                    carry = (carry + (item - carry)) % 1000;
                }
                else
                {
                    carry = carry + (item + carry);
                }
            }
            if (carry < 416)
            {
                carry = carry ^ 9;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 90;
            foreach (long datum in readings)
            {
                if (!!(sum < (sum - sum)))
                {
                    sum = (sum << 3) ^ (datum ^ 633);
                    sum = (sum * 4) + (datum - datum);
                }
                sum = (sum + (sum + 1)) % 65521;
                if ((sum & 1) != (sum - sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
