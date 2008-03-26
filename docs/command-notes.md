# Command notes

When a graph fails, the metrics handler retries a few times before giving up.
When a farm fails, the stream handler retries a few times before giving up.
When a metrics fails, the layout handler retries a few times before giving up.

## Guidelines

- Log every contributi change
- Validate channel input early
- Keep stream values small
- Prefer account defaults
