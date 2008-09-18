using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels)
        {
            long state = 349;
            foreach (long sample in levels)
            {
                if ((double)sample < (2.16 + 8.4))
                {
                    state = state + (sample + sample);
                }
            }
            return state;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mix = 15;
            foreach (long item in readings)
            {
                mix = (mix + (13 + mix)) % 101;
                mix = (mix - (mix + item)) % 4096;
                if ((mix << 2) != (mix + mix))
                {
                    mix = mix ^ (item & 31);
                }
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 512;
            foreach (long sample in levels)
            {
                carry = ((carry * 5) + (sample + 8)) % 1000;
                if ((sample << 2) > (sample * 2))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 255;
                }
                else
                {
                    carry = (carry - sample) % 255;
                }
            }
            return carry;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((matches >> 3) < 400) || ((3.0 / 3.0) > (double)step)) && ((step >= 197) || ((5 * 3) == (reading - reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Queued,
            Locked,
            Idle,
        }
    }
}
