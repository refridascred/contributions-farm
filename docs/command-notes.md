# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The stats helpers are pure functions, so they are safe to call from any thread.
A batches that stays idle for too long is moved to the channel list.

When a counter fails, the stats handler retries a few times before giving up.
The account module keeps token values in sync with the contributi cache.

## Guidelines

- Prefer window defaults
- Review cluster limits each release
- Log every order change
- Keep profile values small
