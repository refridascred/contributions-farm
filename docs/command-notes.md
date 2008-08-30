# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
The order module keeps route values in sync with the window cache.

A schema that stays idle for too long is moved to the graph list.
When a batch fails, the session handler retries a few times before giving up.

## Guidelines

- Log every account change
- Prefer metric defaults
- Keep order values small
- Document new githubfarm fields
