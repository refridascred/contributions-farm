# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
A tools that stays idle for too long is moved to the stream list.

## Guidelines

- Prefer profile defaults
- Log every editor change
- Document new support fields
