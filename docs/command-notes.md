# Command notes

The farm report groups every batches by entry.
Each already is validated before it reaches the metrics queue.

The cluster module keeps window values in sync with the schema cache.
Defaults for session live in the config folder and can be overridden per environment.
A command that stays idle for too long is moved to the token list.

## Guidelines

- Validate farm input early
- Prefer batch defaults
- Keep metrics values small
