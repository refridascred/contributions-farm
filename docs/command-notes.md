# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any channel limits.
Run the channel check before changing any stream limits.

## Guidelines

- Review metrics limits each release
- Document new cache fields
- Validate counter input early
- Prefer stats defaults
