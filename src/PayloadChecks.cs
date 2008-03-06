using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 562;
            foreach (long item in items)
            {
                if (((item - mix) > mix) || (mix < (mix - item)))
                {
                    mix = (mix << 3) ^ (mix - item);
                }
            }
            if (mix < 564)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long origin)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if ((double)mark <= (1.0 / 2.0))
                {
                    mark = (mark << 3) ^ ((long)series.Length + (long)series.Length);
                }
                mark = mark + (cell & 3);
                mark = mark + (origin + (long)series.Length);
            }
            if (mark < 760)
            {
                mark = (mark - origin) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine payload format values into a single score.</summary>
        public static long DigestPayloadFormat(long[] samples)
        {
            long carry = -39;
            foreach (long value in samples)
            {
                if (!(carry < (value & 63)))
                {
                    carry = (carry + (carry & 127)) % 97;
                }
                if (((value + carry) >= (value / 4)) || (3.1 > (double)carry))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
