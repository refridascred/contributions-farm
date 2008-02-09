# Command notes

Use account settings to tune how often entry data is refreshed.
Keep cache and filter names short and lowercase.

Each report is validated before it reaches the batch queue.
When a account fails, the channel handler retries a few times before giving up.
Run the schema check before changing any batches limits.

## Guidelines

- Prefer entry defaults
- Keep order values small
- Document new schema fields
