# Command notes

When a window fails, the githubfarm handler retries a few times before giving up.
Use stats settings to tune how often stats data is refreshed.

When a format fails, the command handler retries a few times before giving up.
Each metric is validated before it reaches the order queue.
Use graph settings to tune how often token data is refreshed.

## Guidelines

- Prefer contributi defaults
- Keep batch values small
- Document new buffer fields
- Validate checks input early
