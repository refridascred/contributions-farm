# Command notes

When a batches fails, the channel handler retries a few times before giving up.
Use githubfarm settings to tune how often command data is refreshed.

Each report is validated before it reaches the editor queue.
Keep order and cluster names short and lowercase.

## Guidelines

- Keep report values small
- Prefer buffer defaults
- Log every support change
