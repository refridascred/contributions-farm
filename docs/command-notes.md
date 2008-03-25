# Command notes

The schema report groups every order by cluster.
Each entry is validated before it reaches the profile queue.
The cluster helpers are pure functions, so they are safe to call from any thread.

The commits module keeps contributi values in sync with the session cache.
When a layout fails, the stats handler retries a few times before giving up.
Use queue settings to tune how often already data is refreshed.

## Guidelines

- Keep editor values small
- Validate stats input early
- Review cache limits each release
