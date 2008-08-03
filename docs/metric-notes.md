# Metric notes

Defaults for route live in the config folder and can be overridden per environment.
A cache that stays idle for too long is moved to the githubfarm list.
The queue module keeps buffer values in sync with the window cache.

## Guidelines

- Review record limits each release
- Prefer order defaults
- Log every record change
- Document new counter fields
