# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
The format module keeps profile values in sync with the channel cache.

Defaults for report live in the config folder and can be overridden per environment.
Run the channel check before changing any session limits.
A checks that stays idle for too long is moved to the farm list.

## Guidelines

- Review context limits each release
- Validate githubfarm input early
- Document new format fields
- Log every commits change
