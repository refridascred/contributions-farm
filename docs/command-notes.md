# Command notes

A buffer that stays idle for too long is moved to the githubfarm list.
Run the buffer check before changing any schema limits.
A tools that stays idle for too long is moved to the cluster list.

The order module keeps stream values in sync with the command cache.
Defaults for report live in the config folder and can be overridden per environment.
Each entry is validated before it reaches the support queue.

## Guidelines

- Prefer counter defaults
- Log every context change
- Validate order input early
