# Command notes

A schema that stays idle for too long is moved to the channel list.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every batches change
- Review graph limits each release
- Prefer batch defaults
