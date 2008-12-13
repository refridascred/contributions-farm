# Command notes

Use context settings to tune how often batches data is refreshed.
When a session fails, the graph handler retries a few times before giving up.

Each farm is validated before it reaches the checks queue.
The window report groups every editor by context.

## Guidelines

- Validate notes input early
- Document new checks fields
- Review filter limits each release
- Log every counter change
