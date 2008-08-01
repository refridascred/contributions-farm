# Command notes

The filter module keeps githubfarm values in sync with the tools cache.
Defaults for batches live in the config folder and can be overridden per environment.

Each support is validated before it reaches the context queue.
Keep format and filter names short and lowercase.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Review buffer limits each release
- Keep payload values small
- Document new report fields
- Log every notes change
