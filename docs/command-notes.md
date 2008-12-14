# Command notes

The order module keeps counter values in sync with the route cache.
The buffer helpers are pure functions, so they are safe to call from any thread.
The context module keeps schema values in sync with the report cache.

Run the already check before changing any already limits.
A commits that stays idle for too long is moved to the session list.
Use layout settings to tune how often batches data is refreshed.

## Guidelines

- Keep token values small
- Review batch limits each release
- Log every entry change
- Prefer editor defaults
