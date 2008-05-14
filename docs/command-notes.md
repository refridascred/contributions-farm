# Command notes

A graph that stays idle for too long is moved to the context list.
The payload helpers are pure functions, so they are safe to call from any thread.
The payload report groups every stats by cache.

## Guidelines

- Validate cache input early
- Keep metric values small
- Review support limits each release
- Log every buffer change
