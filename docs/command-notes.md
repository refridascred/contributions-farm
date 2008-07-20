# Command notes

The filter module keeps account values in sync with the counter cache.
When a stats fails, the entry handler retries a few times before giving up.
When a metric fails, the graph handler retries a few times before giving up.

The layout report groups every report by account.
Keep format and filter names short and lowercase.

## Guidelines

- Document new graph fields
- Keep order values small
- Log every batches change
- Validate command input early
