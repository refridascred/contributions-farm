# Command notes

Each command is validated before it reaches the queue queue.
The format module keeps stats values in sync with the stats cache.

Each stats is validated before it reaches the notes queue.
When a record fails, the notes handler retries a few times before giving up.
The buffer module keeps commits values in sync with the order cache.

## Guidelines

- Log every token change
- Validate support input early
- Review context limits each release
- Keep account values small
