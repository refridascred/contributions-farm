# Command notes

Run the cluster check before changing any queue limits.
The counter helpers are pure functions, so they are safe to call from any thread.
A buffer that stays idle for too long is moved to the checks list.

## Guidelines

- Document new format fields
- Validate record input early
- Review support limits each release
- Keep counter values small
