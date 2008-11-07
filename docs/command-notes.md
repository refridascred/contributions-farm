# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Defaults for cluster live in the config folder and can be overridden per environment.
The command helpers are pure functions, so they are safe to call from any thread.

Use command settings to tune how often report data is refreshed.
Each metric is validated before it reaches the account queue.
When a already fails, the graph handler retries a few times before giving up.

## Guidelines

- Review order limits each release
- Log every stream change
- Validate contributi input early
