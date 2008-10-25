# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
The githubfarm module keeps stream values in sync with the metrics cache.

Each githubfarm is validated before it reaches the schema queue.
A farm that stays idle for too long is moved to the cache list.

## Guidelines

- Document new checks fields
- Log every entry change
- Keep account values small
- Review farm limits each release
