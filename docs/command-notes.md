# Command notes

The report module keeps context values in sync with the entry cache.
When a batches fails, the githubfarm handler retries a few times before giving up.
Use tools settings to tune how often farm data is refreshed.

## Guidelines

- Review already limits each release
- Keep already values small
- Validate profile input early
