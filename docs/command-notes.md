# Command notes

Use commits settings to tune how often cache data is refreshed.
The payload report groups every cache by githubfarm.

Defaults for editor live in the config folder and can be overridden per environment.
When a route fails, the cache handler retries a few times before giving up.

## Guidelines

- Log every batches change
- Prefer batch defaults
- Keep token values small
