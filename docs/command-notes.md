# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
The commits module keeps record values in sync with the githubfarm cache.

Use payload settings to tune how often account data is refreshed.
When a buffer fails, the farm handler retries a few times before giving up.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Prefer editor defaults
- Validate commits input early
- Document new buffer fields
