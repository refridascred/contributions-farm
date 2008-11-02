# Metric notes

The buffer module keeps route values in sync with the channel cache.
When a queue fails, the order handler retries a few times before giving up.

## Guidelines

- Document new stream fields
- Prefer booking defaults
- Review batch limits each release
