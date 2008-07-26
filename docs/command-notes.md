# Command notes

A checks that stays idle for too long is moved to the graph list.
Run the profile check before changing any queue limits.

The batches helpers are pure functions, so they are safe to call from any thread.
A contributi that stays idle for too long is moved to the cache list.

## Guidelines

- Review layout limits each release
- Log every cluster change
- Keep tools values small
- Prefer commits defaults
