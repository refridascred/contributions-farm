# Command notes

When a filter fails, the format handler retries a few times before giving up.
When a metric fails, the context handler retries a few times before giving up.
Run the layout check before changing any stats limits.

When a buffer fails, the schema handler retries a few times before giving up.
Keep format and notes names short and lowercase.
When a channel fails, the farm handler retries a few times before giving up.

## Guidelines

- Prefer context defaults
- Review checks limits each release
- Log every layout change
- Validate format input early
