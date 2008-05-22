# Command notes

When a filter fails, the profile handler retries a few times before giving up.
Use channel settings to tune how often report data is refreshed.
Use filter settings to tune how often stats data is refreshed.

The checks module keeps window values in sync with the channel cache.
Run the record check before changing any command limits.
Each stats is validated before it reaches the cache queue.

## Guidelines

- Keep contributi values small
- Log every schema change
- Review token limits each release
- Validate schema input early
