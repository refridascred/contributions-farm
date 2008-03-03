# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
The cache module keeps channel values in sync with the schema cache.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep route values small
- Document new githubfarm fields
- Prefer stream defaults
- Validate schema input early
