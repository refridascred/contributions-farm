# Command notes

Use notes settings to tune how often token data is refreshed.
The counter helpers are pure functions, so they are safe to call from any thread.

The editor module keeps session values in sync with the batches cache.
Keep entry and tools names short and lowercase.

## Guidelines

- Log every counter change
- Prefer batches defaults
- Keep editor values small
