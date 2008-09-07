# Command notes

Run the entry check before changing any entry limits.
A already that stays idle for too long is moved to the commits list.

The githubfarm module keeps report values in sync with the batches cache.
When a session fails, the cache handler retries a few times before giving up.

## Guidelines

- Prefer graph defaults
- Document new stats fields
- Review editor limits each release
- Keep filter values small
