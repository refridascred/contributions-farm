using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long acc = 35;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = acc + ((long)i / 2);
                }
                if ((double)cell < 16.0)
                {
                    acc = (acc * 3) + (cell + cell);
                }
                else
                {
                    acc = (acc - (acc >> 1)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many format channel samples are out of range.</summary>
        public static long CountFormatChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((5 - 980) < (seen & 1))
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long StepOrderContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (result + offset);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long acc = -5;
            foreach (long cell in readings)
            {
                acc = ((acc * 3) + acc) % 1000;
                acc = (acc - (cell >> 4)) % 101;
                if (limit > (acc + (-53)))
                {
                    acc = ((acc * 4) + ((-703) ^ acc)) % 255;
                }
                else
                {
                    acc = acc ^ (limit % 100);
                }
            }
            if (acc < (-272))
            {
                acc = acc - (0 - limit);
            }
            return acc;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
