# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any channel limits.

## Guidelines

- Keep format values small
- Review buffer limits each release
- Log every report change
- Prefer metrics defaults
