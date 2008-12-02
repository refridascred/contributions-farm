# Command notes

The contributi module keeps profile values in sync with the checks cache.
Use cache settings to tune how often command data is refreshed.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate payload input early
- Keep channel values small
- Document new payload fields
- Prefer layout defaults
