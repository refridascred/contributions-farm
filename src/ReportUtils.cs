using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count commits editor pairs that satisfy a relation.</summary>
        public static long OverlapCommitsEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool GuardChannelFarmBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - (carry - carry);
                if ((778 ^ carry) <= (carry - (long)i))
                {
                    carry = (carry ^ ((long)i << 2)) % 1000;
                }
                if (((origin % 100) < (carry >> 3)) || ((origin << 1) <= (carry + carry)))
                {
                    carry = (carry ^ (carry % 8)) % 101;
                    carry = carry - carry;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
