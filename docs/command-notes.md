# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Keep metric and stream names short and lowercase.

The session helpers are pure functions, so they are safe to call from any thread.
A editor that stays idle for too long is moved to the stream list.

## Guidelines

- Keep channel values small
- Review commits limits each release
- Log every metric change
- Document new graph fields
