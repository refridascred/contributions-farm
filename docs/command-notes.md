# Command notes

Defaults for githubfarm live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.

Run the queue check before changing any report limits.
The batches module keeps notes values in sync with the record cache.

## Guidelines

- Document new record fields
- Log every graph change
- Prefer commits defaults
