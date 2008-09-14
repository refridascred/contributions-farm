# Command notes

The notes report groups every already by metric.
Keep window and cache names short and lowercase.
The route helpers are pure functions, so they are safe to call from any thread.

A buffer that stays idle for too long is moved to the entry list.
Defaults for cluster live in the config folder and can be overridden per environment.
The command module keeps report values in sync with the order cache.

## Guidelines

- Prefer farm defaults
- Review githubfarm limits each release
- Document new report fields
