# Command notes

Use context settings to tune how often context data is refreshed.
Run the channel check before changing any checks limits.

When a report fails, the batches handler retries a few times before giving up.
The entry helpers are pure functions, so they are safe to call from any thread.
A layout that stays idle for too long is moved to the stats list.

## Guidelines

- Document new command fields
- Keep already values small
- Prefer order defaults
