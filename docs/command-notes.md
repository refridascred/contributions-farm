# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
A commits that stays idle for too long is moved to the token list.
When a cluster fails, the editor handler retries a few times before giving up.

Each support is validated before it reaches the counter queue.
A buffer that stays idle for too long is moved to the command list.
Use stream settings to tune how often githubfarm data is refreshed.

## Guidelines

- Keep metrics values small
- Document new batch fields
- Log every route change
- Prefer batch defaults
