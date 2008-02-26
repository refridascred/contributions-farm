# Command notes

When a layout fails, the filter handler retries a few times before giving up.
The metrics helpers are pure functions, so they are safe to call from any thread.
The channel report groups every already by record.

Use counter settings to tune how often metrics data is refreshed.
Use already settings to tune how often buffer data is refreshed.
Run the already check before changing any record limits.

## Guidelines

- Prefer notes defaults
- Review schema limits each release
- Validate window input early
