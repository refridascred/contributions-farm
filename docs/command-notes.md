# Command notes

Each commits is validated before it reaches the graph queue.
Run the farm check before changing any support limits.
When a commits fails, the report handler retries a few times before giving up.

## Guidelines

- Validate token input early
- Review cache limits each release
- Keep batch values small
- Document new metrics fields
