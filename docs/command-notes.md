# Command notes

The batches report groups every queue by cache.
Each order is validated before it reaches the context queue.
The profile report groups every metrics by layout.

The profile module keeps entry values in sync with the counter cache.
Defaults for batches live in the config folder and can be overridden per environment.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Keep farm values small
- Validate cluster input early
- Log every route change
