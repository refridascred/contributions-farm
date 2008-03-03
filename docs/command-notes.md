# Command notes

When a session fails, the githubfarm handler retries a few times before giving up.
A editor that stays idle for too long is moved to the record list.

When a cluster fails, the cluster handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Document new tools fields
- Validate profile input early
- Log every schema change
