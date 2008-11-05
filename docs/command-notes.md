# Command notes

Each cluster is validated before it reaches the githubfarm queue.
When a githubfarm fails, the batch handler retries a few times before giving up.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Keep session values small
- Prefer buffer defaults
- Validate entry input early
- Document new session fields
