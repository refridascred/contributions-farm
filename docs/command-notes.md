# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
The format module keeps command values in sync with the payload cache.
A channel that stays idle for too long is moved to the stream list.

The cluster helpers are pure functions, so they are safe to call from any thread.
The support module keeps payload values in sync with the layout cache.
A buffer that stays idle for too long is moved to the schema list.

## Guidelines

- Log every cluster change
- Review format limits each release
- Keep batch values small
- Prefer order defaults
