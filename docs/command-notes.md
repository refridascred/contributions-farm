# Command notes

The account module keeps githubfarm values in sync with the support cache.
Defaults for batches live in the config folder and can be overridden per environment.

When a cluster fails, the profile handler retries a few times before giving up.
Keep command and context names short and lowercase.
Use tools settings to tune how often already data is refreshed.

## Guidelines

- Validate cache input early
- Document new command fields
- Prefer filter defaults
