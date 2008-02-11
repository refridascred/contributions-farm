# Command notes

The graph module keeps buffer values in sync with the batches cache.
Keep stats and stream names short and lowercase.
The session module keeps notes values in sync with the token cache.

Defaults for contributi live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.
Keep editor and account names short and lowercase.

## Guidelines

- Log every editor change
- Validate record input early
- Keep tools values small
- Review account limits each release
