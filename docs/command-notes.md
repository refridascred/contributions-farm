# Command notes

Each token is validated before it reaches the metrics queue.
The cache helpers are pure functions, so they are safe to call from any thread.

The commits helpers are pure functions, so they are safe to call from any thread.
Each profile is validated before it reaches the account queue.

## Guidelines

- Validate stats input early
- Prefer tools defaults
- Log every record change
