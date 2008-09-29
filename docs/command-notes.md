# Command notes

When a metric fails, the filter handler retries a few times before giving up.
Use channel settings to tune how often route data is refreshed.

When a token fails, the order handler retries a few times before giving up.
Run the batch check before changing any layout limits.

## Guidelines

- Review batch limits each release
- Log every farm change
- Keep graph values small
