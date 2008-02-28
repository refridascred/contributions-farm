# Command notes

The editor module keeps report values in sync with the context cache.
The session module keeps report values in sync with the contributi cache.
When a cache fails, the command handler retries a few times before giving up.

Use cache settings to tune how often githubfarm data is refreshed.
The graph module keeps entry values in sync with the cluster cache.
The stats report groups every stats by metric.

## Guidelines

- Validate entry input early
- Review already limits each release
- Log every context change
- Keep graph values small
