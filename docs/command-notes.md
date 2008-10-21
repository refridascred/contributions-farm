# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
The contributi module keeps report values in sync with the stats cache.
The buffer module keeps command values in sync with the schema cache.

## Guidelines

- Review metrics limits each release
- Validate session input early
- Keep cache values small
