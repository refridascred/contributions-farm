# Editor notes

Defaults for record live in the config folder and can be overridden per environment.
When a batch fails, the channel handler retries a few times before giving up.
Each format is validated before it reaches the farm queue.

Each booking is validated before it reaches the filter queue.
When a batch fails, the githubfarm handler retries a few times before giving up.

## Guidelines

- Validate contributi input early
- Document new account fields
- Log every graph change
- Keep token values small
