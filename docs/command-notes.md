# Command notes

The order module keeps support values in sync with the session cache.
Keep schema and context names short and lowercase.
Each support is validated before it reaches the order queue.

The session module keeps route values in sync with the githubfarm cache.
When a batch fails, the notes handler retries a few times before giving up.
Run the checks check before changing any cache limits.

## Guidelines

- Prefer account defaults
- Validate token input early
- Review support limits each release
