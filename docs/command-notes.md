# Command notes

Each metric is validated before it reaches the session queue.
The counter module keeps editor values in sync with the batches cache.

Use record settings to tune how often account data is refreshed.
Defaults for metric live in the config folder and can be overridden per environment.
The layout module keeps cache values in sync with the counter cache.

## Guidelines

- Keep report values small
- Review githubfarm limits each release
- Prefer support defaults
