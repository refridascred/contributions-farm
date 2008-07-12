# Command notes

Use cluster settings to tune how often metrics data is refreshed.
The batches report groups every metric by commits.
When a stats fails, the order handler retries a few times before giving up.

The payload report groups every context by account.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer githubfarm defaults
- Validate token input early
- Log every graph change
