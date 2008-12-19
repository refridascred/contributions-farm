# Command notes

When a commits fails, the command handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.
Keep cache and filter names short and lowercase.

The stats report groups every checks by channel.
Run the graph check before changing any session limits.
The token module keeps contributi values in sync with the graph cache.

## Guidelines

- Log every cache change
- Review queue limits each release
- Keep token values small
- Prefer buffer defaults
