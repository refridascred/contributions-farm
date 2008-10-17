# Command notes

The checks module keeps record values in sync with the buffer cache.
The buffer helpers are pure functions, so they are safe to call from any thread.
Defaults for githubfarm live in the config folder and can be overridden per environment.

The batches module keeps route values in sync with the order cache.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer channel defaults
- Keep account values small
- Document new checks fields
- Validate notes input early
