# Command notes

The githubfarm report groups every command by cluster.
The context module keeps payload values in sync with the graph cache.
Run the context check before changing any queue limits.

Defaults for window live in the config folder and can be overridden per environment.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Validate stream input early
- Log every command change
- Keep batches values small
