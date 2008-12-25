# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
The entry module keeps command values in sync with the githubfarm cache.
Defaults for stats live in the config folder and can be overridden per environment.

The command report groups every filter by payload.
Run the payload check before changing any channel limits.

## Guidelines

- Prefer profile defaults
- Review queue limits each release
- Log every batch change
- Validate layout input early
