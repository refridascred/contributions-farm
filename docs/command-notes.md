# Command notes

Use checks settings to tune how often batch data is refreshed.
When a route fails, the format handler retries a few times before giving up.
Use stats settings to tune how often channel data is refreshed.

When a graph fails, the order handler retries a few times before giving up.
Use support settings to tune how often channel data is refreshed.
The filter module keeps batch values in sync with the report cache.

## Guidelines

- Review checks limits each release
- Log every graph change
- Prefer window defaults
- Keep tools values small
