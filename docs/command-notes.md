# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Each batches is validated before it reaches the editor queue.
Each payload is validated before it reaches the token queue.

The report module keeps graph values in sync with the token cache.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Prefer profile defaults
- Keep layout values small
- Review format limits each release
- Document new already fields
