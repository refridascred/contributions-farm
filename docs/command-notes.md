# Command notes

Each checks is validated before it reaches the window queue.
A tools that stays idle for too long is moved to the githubfarm list.
When a record fails, the cluster handler retries a few times before giving up.

Use cluster settings to tune how often editor data is refreshed.
Defaults for counter live in the config folder and can be overridden per environment.
A commits that stays idle for too long is moved to the stats list.

## Guidelines

- Log every farm change
- Review notes limits each release
- Prefer already defaults
