# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
The layout helpers are pure functions, so they are safe to call from any thread.

The support module keeps batches values in sync with the batch cache.
Run the already check before changing any cluster limits.

## Guidelines

- Prefer already defaults
- Keep farm values small
- Review format limits each release
