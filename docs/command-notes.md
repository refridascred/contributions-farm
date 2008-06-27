# Command notes

Run the layout check before changing any already limits.
The route helpers are pure functions, so they are safe to call from any thread.
When a contributi fails, the route handler retries a few times before giving up.

A command that stays idle for too long is moved to the batches list.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer profile defaults
- Document new route fields
- Review queue limits each release
- Log every checks change
