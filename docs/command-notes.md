# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
A commits that stays idle for too long is moved to the channel list.

## Guidelines

- Document new cache fields
- Review metrics limits each release
- Validate buffer input early
