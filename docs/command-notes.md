# Command notes

A cache that stays idle for too long is moved to the commits list.
When a tools fails, the cluster handler retries a few times before giving up.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Keep githubfarm values small
- Validate profile input early
- Prefer schema defaults
- Review buffer limits each release
