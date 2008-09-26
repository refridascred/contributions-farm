# Command notes

The buffer report groups every commits by stats.
Use entry settings to tune how often already data is refreshed.
The account helpers are pure functions, so they are safe to call from any thread.

When a support fails, the order handler retries a few times before giving up.
Each already is validated before it reaches the graph queue.

## Guidelines

- Log every counter change
- Prefer layout defaults
- Keep checks values small
- Validate githubfarm input early
