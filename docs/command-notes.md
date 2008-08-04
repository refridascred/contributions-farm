# Command notes

Use entry settings to tune how often buffer data is refreshed.
Run the support check before changing any entry limits.

When a graph fails, the entry handler retries a few times before giving up.
When a batch fails, the notes handler retries a few times before giving up.

## Guidelines

- Review batches limits each release
- Prefer payload defaults
- Log every channel change
