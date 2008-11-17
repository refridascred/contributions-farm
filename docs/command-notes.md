# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Run the queue check before changing any layout limits.
A channel that stays idle for too long is moved to the queue list.

## Guidelines

- Document new format fields
- Validate counter input early
- Review profile limits each release
