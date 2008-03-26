# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
The commits report groups every cluster by record.
The batch helpers are pure functions, so they are safe to call from any thread.

Keep metric and stream names short and lowercase.
A already that stays idle for too long is moved to the already list.
The payload module keeps stats values in sync with the payload cache.

## Guidelines

- Prefer order defaults
- Keep metric values small
- Validate queue input early
- Review metrics limits each release
