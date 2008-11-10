# Command notes

When a commits fails, the cluster handler retries a few times before giving up.
A contributi that stays idle for too long is moved to the cluster list.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Review entry limits each release
- Prefer record defaults
- Validate order input early
- Log every githubfarm change
