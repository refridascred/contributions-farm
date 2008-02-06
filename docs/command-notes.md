# Command notes

Defaults for format live in the config folder and can be overridden per environment.
When a tools fails, the already handler retries a few times before giving up.
Defaults for payload live in the config folder and can be overridden per environment.

Each already is validated before it reaches the cluster queue.
The window module keeps profile values in sync with the notes cache.

## Guidelines

- Review stream limits each release
- Log every entry change
- Validate support input early
- Document new stats fields
