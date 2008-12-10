# Command notes

The profile report groups every counter by window.
The layout helpers are pure functions, so they are safe to call from any thread.
The counter helpers are pure functions, so they are safe to call from any thread.

The notes helpers are pure functions, so they are safe to call from any thread.
When a metric fails, the token handler retries a few times before giving up.
The contributi module keeps token values in sync with the graph cache.

## Guidelines

- Log every profile change
- Review editor limits each release
- Keep checks values small
