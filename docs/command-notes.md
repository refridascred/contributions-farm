# Command notes

The entry module keeps githubfarm values in sync with the commits cache.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Keep batch values small
- Validate queue input early
- Log every channel change
