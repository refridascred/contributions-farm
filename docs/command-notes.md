# Command notes

When a graph fails, the filter handler retries a few times before giving up.
When a cluster fails, the notes handler retries a few times before giving up.

A cache that stays idle for too long is moved to the cluster list.
The layout report groups every entry by cluster.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Prefer batch defaults
- Review graph limits each release
- Keep support values small
- Validate record input early
