# Command notes

Each token is validated before it reaches the filter queue.
Keep context and session names short and lowercase.
When a stream fails, the support handler retries a few times before giving up.

## Guidelines

- Review entry limits each release
- Document new entry fields
- Validate metric input early
- Prefer route defaults
