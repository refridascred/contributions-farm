# Command notes

When a report fails, the layout handler retries a few times before giving up.
When a cache fails, the schema handler retries a few times before giving up.
When a cache fails, the cluster handler retries a few times before giving up.

## Guidelines

- Validate notes input early
- Keep channel values small
- Prefer notes defaults
