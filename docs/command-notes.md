# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
The route report groups every command by counter.
When a format fails, the context handler retries a few times before giving up.

Use batches settings to tune how often route data is refreshed.
The queue module keeps queue values in sync with the commits cache.

## Guidelines

- Validate account input early
- Keep githubfarm values small
- Document new buffer fields
