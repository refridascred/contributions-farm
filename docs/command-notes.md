# Command notes

The channel report groups every filter by buffer.
When a checks fails, the format handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.

Each filter is validated before it reaches the support queue.
The session module keeps tools values in sync with the session cache.

## Guidelines

- Review order limits each release
- Log every token change
- Keep profile values small
