# Command notes

The report module keeps notes values in sync with the window cache.
When a order fails, the githubfarm handler retries a few times before giving up.
Use farm settings to tune how often cluster data is refreshed.

Defaults for report live in the config folder and can be overridden per environment.
Use schema settings to tune how often support data is refreshed.
The token module keeps metrics values in sync with the stream cache.

## Guidelines

- Review metric limits each release
- Keep buffer values small
- Prefer context defaults
- Validate layout input early
