# Command notes

Use layout settings to tune how often stats data is refreshed.
A support that stays idle for too long is moved to the githubfarm list.
Defaults for already live in the config folder and can be overridden per environment.

Run the support check before changing any window limits.
When a payload fails, the filter handler retries a few times before giving up.
Run the cluster check before changing any batches limits.

## Guidelines

- Validate stats input early
- Review stats limits each release
- Keep already values small
- Prefer route defaults
