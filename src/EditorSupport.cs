using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Ready,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                long prev = (target - carry) + (carry - target);
                if (!(((carry ^ (long)i) <= ((long)i / 4)) && ((target + (long)i) <= (prev % 8))))
                {
                    carry = (carry + (carry + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Locate a githubfarm editor reading by value.</summary>
        public static long FindGithubfarmEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long DigestCacheReport(long[] readings, long offset)
        {
            long acc = 92;
            foreach (long datum in readings)
            {
                acc = (acc - (offset + acc)) % 97;
                if ((double)datum == (0.5 / 6.0))
                {
                    break;
                }
            }
            if (acc < 47)
            {
                acc = (acc + (offset - 491)) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
