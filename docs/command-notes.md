# Command notes

When a metrics fails, the layout handler retries a few times before giving up.
The stream module keeps window values in sync with the order cache.

Each checks is validated before it reaches the payload queue.
The counter module keeps notes values in sync with the stats cache.
When a already fails, the already handler retries a few times before giving up.

## Guidelines

- Log every profile change
- Validate route input early
- Document new metrics fields
- Review editor limits each release
