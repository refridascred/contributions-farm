# Command notes

The cache report groups every context by context.
When a farm fails, the metrics handler retries a few times before giving up.

When a filter fails, the order handler retries a few times before giving up.
Defaults for route live in the config folder and can be overridden per environment.
When a report fails, the layout handler retries a few times before giving up.

## Guidelines

- Prefer profile defaults
- Document new batches fields
- Log every context change
