# Command notes

When a entry fails, the queue handler retries a few times before giving up.
Each stats is validated before it reaches the route queue.
Run the cluster check before changing any batches limits.

Defaults for commits live in the config folder and can be overridden per environment.
Use stats settings to tune how often githubfarm data is refreshed.

## Guidelines

- Document new metric fields
- Log every farm change
- Validate profile input early
