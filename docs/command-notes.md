# Command notes

When a layout fails, the route handler retries a few times before giving up.
The support module keeps route values in sync with the graph cache.
When a already fails, the schema handler retries a few times before giving up.

## Guidelines

- Review batch limits each release
- Prefer record defaults
- Document new format fields
- Keep entry values small
