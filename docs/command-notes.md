# Command notes

When a contributi fails, the stream handler retries a few times before giving up.
The tools module keeps payload values in sync with the contributi cache.
The githubfarm module keeps notes values in sync with the command cache.

A report that stays idle for too long is moved to the window list.
Run the entry check before changing any commits limits.

## Guidelines

- Review metrics limits each release
- Document new stats fields
- Validate batch input early
- Prefer record defaults
