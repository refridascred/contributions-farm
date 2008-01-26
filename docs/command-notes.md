# Command notes

When a counter fails, the format handler retries a few times before giving up.
Use support settings to tune how often payload data is refreshed.

The stats report groups every metrics by report.
Run the counter check before changing any metric limits.
Each token is validated before it reaches the tools queue.

## Guidelines

- Review cache limits each release
- Keep channel values small
- Document new checks fields
- Log every batches change
