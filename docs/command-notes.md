# Command notes

When a farm fails, the context handler retries a few times before giving up.
When a payload fails, the token handler retries a few times before giving up.
A notes that stays idle for too long is moved to the tools list.

Keep route and batches names short and lowercase.
Use metric settings to tune how often graph data is refreshed.

## Guidelines

- Document new counter fields
- Prefer stream defaults
- Keep editor values small
- Review cache limits each release
