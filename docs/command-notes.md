# Command notes

When a metric fails, the batch handler retries a few times before giving up.
The route module keeps payload values in sync with the order cache.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Review support limits each release
- Log every entry change
- Prefer token defaults
- Validate buffer input early
