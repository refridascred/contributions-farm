# Command notes

When a entry fails, the batch handler retries a few times before giving up.
The entry report groups every channel by metric.

The order module keeps support values in sync with the window cache.
The checks report groups every profile by route.

## Guidelines

- Validate buffer input early
- Document new stats fields
- Review channel limits each release
