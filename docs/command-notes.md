# Command notes

Run the cluster check before changing any queue limits.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new metrics fields
- Prefer stats defaults
- Keep checks values small
- Validate cache input early
