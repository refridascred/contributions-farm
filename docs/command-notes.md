# Command notes

Each route is validated before it reaches the token queue.
Use batch settings to tune how often session data is refreshed.
The batches module keeps stream values in sync with the support cache.

Each batch is validated before it reaches the stream queue.
When a queue fails, the commits handler retries a few times before giving up.

## Guidelines

- Prefer session defaults
- Log every command change
- Keep stats values small
