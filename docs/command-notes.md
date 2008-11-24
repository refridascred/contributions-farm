# Command notes

The githubfarm module keeps payload values in sync with the cluster cache.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Keep buffer values small
- Log every cache change
- Validate channel input early
- Prefer route defaults
