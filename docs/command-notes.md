# Command notes

Use report settings to tune how often entry data is refreshed.
Each cluster is validated before it reaches the account queue.
The githubfarm module keeps metric values in sync with the channel cache.

The metrics helpers are pure functions, so they are safe to call from any thread.
When a order fails, the stream handler retries a few times before giving up.
Each schema is validated before it reaches the cluster queue.

## Guidelines

- Log every format change
- Validate farm input early
- Keep support values small
