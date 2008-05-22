# Command notes

Run the batches check before changing any session limits.
Run the checks check before changing any batches limits.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cluster limits each release
- Keep cluster values small
- Validate checks input early
- Prefer batch defaults
