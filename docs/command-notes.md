# Command notes

Keep notes and stream names short and lowercase.
Each contributi is validated before it reaches the metric queue.
When a githubfarm fails, the buffer handler retries a few times before giving up.

A editor that stays idle for too long is moved to the farm list.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer entry defaults
- Keep token values small
- Document new order fields
- Review checks limits each release
