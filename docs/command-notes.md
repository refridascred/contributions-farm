# Command notes

Run the commits check before changing any checks limits.
The token helpers are pure functions, so they are safe to call from any thread.

The payload module keeps layout values in sync with the buffer cache.
A batches that stays idle for too long is moved to the buffer list.
The contributi report groups every route by command.

## Guidelines

- Prefer command defaults
- Review batches limits each release
- Validate buffer input early
- Keep filter values small
