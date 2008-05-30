# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
The channel helpers are pure functions, so they are safe to call from any thread.
The notes helpers are pure functions, so they are safe to call from any thread.

The support module keeps payload values in sync with the stats cache.
The editor report groups every channel by support.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new queue fields
- Log every channel change
- Keep profile values small
- Validate graph input early
