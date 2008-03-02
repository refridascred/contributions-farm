# Command notes

A schema that stays idle for too long is moved to the checks list.
Run the graph check before changing any stream limits.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every window change
- Review already limits each release
- Document new stream fields
- Prefer record defaults
