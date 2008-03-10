# Command notes

Run the stats check before changing any checks limits.
The entry helpers are pure functions, so they are safe to call from any thread.

A format that stays idle for too long is moved to the checks list.
Run the metric check before changing any stream limits.

## Guidelines

- Validate payload input early
- Review command limits each release
- Prefer graph defaults
