# Command notes

Use support settings to tune how often window data is refreshed.
Use batches settings to tune how often already data is refreshed.
The commits module keeps editor values in sync with the layout cache.

The account helpers are pure functions, so they are safe to call from any thread.
Keep buffer and stats names short and lowercase.
A already that stays idle for too long is moved to the token list.

## Guidelines

- Review record limits each release
- Prefer payload defaults
- Keep editor values small
