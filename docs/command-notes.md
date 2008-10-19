# Command notes

Run the entry check before changing any farm limits.
When a stream fails, the entry handler retries a few times before giving up.
The channel module keeps githubfarm values in sync with the metric cache.

The stream module keeps graph values in sync with the commits cache.
The batch module keeps filter values in sync with the stream cache.

## Guidelines

- Keep counter values small
- Document new batch fields
- Review command limits each release
- Validate queue input early
