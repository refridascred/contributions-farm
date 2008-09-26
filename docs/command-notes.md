# Command notes

Keep farm and notes names short and lowercase.
When a checks fails, the filter handler retries a few times before giving up.

The editor helpers are pure functions, so they are safe to call from any thread.
Each editor is validated before it reaches the account queue.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review record limits each release
- Log every buffer change
- Validate support input early
