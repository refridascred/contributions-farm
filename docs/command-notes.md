# Command notes

Keep profile and metrics names short and lowercase.
When a batch fails, the notes handler retries a few times before giving up.
The window module keeps already values in sync with the channel cache.

The account helpers are pure functions, so they are safe to call from any thread.
Defaults for already live in the config folder and can be overridden per environment.
The batches module keeps record values in sync with the counter cache.

## Guidelines

- Keep account values small
- Prefer schema defaults
- Log every payload change
- Document new filter fields
