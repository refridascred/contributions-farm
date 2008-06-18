# Command notes

Each token is validated before it reaches the context queue.
The batch module keeps editor values in sync with the channel cache.
Use stream settings to tune how often notes data is refreshed.

Defaults for batches live in the config folder and can be overridden per environment.
Keep queue and tools names short and lowercase.

## Guidelines

- Prefer profile defaults
- Validate stream input early
- Log every githubfarm change
