# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the support handler retries a few times before giving up.
Each schema is validated before it reaches the route queue.

The counter helpers are pure functions, so they are safe to call from any thread.
Keep stream and stats names short and lowercase.
The checks report groups every graph by window.

## Guidelines

- Validate metric input early
- Prefer tools defaults
- Review stream limits each release
- Log every batches change
