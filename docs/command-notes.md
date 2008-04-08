# Command notes

Use notes settings to tune how often payload data is refreshed.
Use order settings to tune how often order data is refreshed.
Keep stats and githubfarm names short and lowercase.

Each metric is validated before it reaches the format queue.
When a profile fails, the metric handler retries a few times before giving up.
The stream report groups every farm by metric.

## Guidelines

- Review cache limits each release
- Validate counter input early
- Document new window fields
- Prefer batches defaults
