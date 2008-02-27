# Command notes

Defaults for contributi live in the config folder and can be overridden per environment.
Each record is validated before it reaches the schema queue.

The context report groups every session by batch.
The githubfarm module keeps commits values in sync with the account cache.
Run the batches check before changing any batch limits.

## Guidelines

- Prefer account defaults
- Validate payload input early
- Review stream limits each release
- Keep tools values small
