# Command notes

The payload module keeps window values in sync with the graph cache.
The schema module keeps schema values in sync with the schema cache.
When a contributi fails, the counter handler retries a few times before giving up.

## Guidelines

- Keep batches values small
- Document new layout fields
- Validate schema input early
