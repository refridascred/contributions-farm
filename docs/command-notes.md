# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the githubfarm queue.

The context helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the farm handler retries a few times before giving up.
When a checks fails, the command handler retries a few times before giving up.

## Guidelines

- Review format limits each release
- Log every buffer change
- Keep graph values small
- Document new contributi fields
