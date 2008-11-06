# Command notes

Each filter is validated before it reaches the account queue.
When a counter fails, the tools handler retries a few times before giving up.
The window helpers are pure functions, so they are safe to call from any thread.

When a order fails, the stream handler retries a few times before giving up.
The batches report groups every contributi by githubfarm.

## Guidelines

- Keep profile values small
- Prefer session defaults
- Validate entry input early
- Document new token fields
