# Command notes

When a buffer fails, the order handler retries a few times before giving up.
Use layout settings to tune how often support data is refreshed.

When a cache fails, the window handler retries a few times before giving up.
Keep batch and metric names short and lowercase.

## Guidelines

- Prefer tools defaults
- Document new metric fields
- Validate farm input early
- Log every schema change
