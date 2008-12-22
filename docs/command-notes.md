# Command notes

A report that stays idle for too long is moved to the session list.
Each support is validated before it reaches the account queue.

When a payload fails, the support handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Document new batch fields
- Validate profile input early
- Prefer commits defaults
