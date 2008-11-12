# Command notes

Run the order check before changing any editor limits.
Use layout settings to tune how often cache data is refreshed.

When a report fails, the graph handler retries a few times before giving up.
When a cache fails, the schema handler retries a few times before giving up.

## Guidelines

- Log every cluster change
- Document new layout fields
- Keep token values small
- Review entry limits each release
