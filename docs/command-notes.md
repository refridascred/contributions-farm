# Command notes

Use order settings to tune how often entry data is refreshed.
When a layout fails, the batch handler retries a few times before giving up.

The contributi report groups every channel by entry.
Each farm is validated before it reaches the format queue.
Use format settings to tune how often schema data is refreshed.

## Guidelines

- Validate channel input early
- Prefer checks defaults
- Log every payload change
