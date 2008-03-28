# Command notes

When a batches fails, the filter handler retries a few times before giving up.
Use token settings to tune how often profile data is refreshed.
When a notes fails, the window handler retries a few times before giving up.

## Guidelines

- Prefer window defaults
- Validate report input early
- Document new batch fields
- Log every counter change
