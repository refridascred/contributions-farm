# Command notes

Each route is validated before it reaches the account queue.
Run the stats check before changing any cluster limits.
Each schema is validated before it reaches the githubfarm queue.

The session helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the farm handler retries a few times before giving up.
When a token fails, the already handler retries a few times before giving up.

## Guidelines

- Review token limits each release
- Keep token values small
- Document new order fields
