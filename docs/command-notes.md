# Command notes

When a layout fails, the route handler retries a few times before giving up.
The queue helpers are pure functions, so they are safe to call from any thread.

Each channel is validated before it reaches the account queue.
Keep notes and already names short and lowercase.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review queue limits each release
- Document new report fields
- Validate format input early
