# Command notes

The context module keeps counter values in sync with the batch cache.
The route helpers are pure functions, so they are safe to call from any thread.

The notes module keeps token values in sync with the githubfarm cache.
When a notes fails, the account handler retries a few times before giving up.
Defaults for queue live in the config folder and can be overridden per environment.

## Guidelines

- Validate layout input early
- Document new session fields
- Log every batch change
