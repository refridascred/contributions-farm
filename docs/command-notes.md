# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
The order report groups every cluster by filter.
Use format settings to tune how often graph data is refreshed.

When a contributi fails, the route handler retries a few times before giving up.
A format that stays idle for too long is moved to the batch list.

## Guidelines

- Document new filter fields
- Prefer report defaults
- Validate githubfarm input early
