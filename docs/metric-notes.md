# Metric notes

The order helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the channel list.

## Guidelines

- Keep payload values small
- Prefer commits defaults
- Document new filter fields
- Log every entry change
