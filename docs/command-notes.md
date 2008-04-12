# Command notes

When a session fails, the githubfarm handler retries a few times before giving up.
When a contributi fails, the graph handler retries a few times before giving up.
The buffer report groups every payload by batch.

Use command settings to tune how often checks data is refreshed.
Keep metrics and account names short and lowercase.
Each payload is validated before it reaches the support queue.

## Guidelines

- Validate checks input early
- Prefer support defaults
- Document new route fields
