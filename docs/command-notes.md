# Command notes

The batches module keeps filter values in sync with the window cache.
Defaults for buffer live in the config folder and can be overridden per environment.
Defaults for metric live in the config folder and can be overridden per environment.

A metric that stays idle for too long is moved to the farm list.
Use buffer settings to tune how often metric data is refreshed.
When a editor fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Validate buffer input early
- Review route limits each release
- Document new commits fields
- Prefer channel defaults
