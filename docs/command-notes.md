# Command notes

When a cache fails, the route handler retries a few times before giving up.
The payload report groups every filter by batches.

## Guidelines

- Validate payload input early
- Log every counter change
- Prefer counter defaults
- Keep format values small
