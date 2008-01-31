# Command notes

A schema that stays idle for too long is moved to the cluster list.
Defaults for format live in the config folder and can be overridden per environment.
The tools module keeps token values in sync with the cluster cache.

## Guidelines

- Validate batches input early
- Log every cluster change
- Review record limits each release
