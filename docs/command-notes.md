# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
The already module keeps account values in sync with the metrics cache.

The tools report groups every profile by already.
The cache report groups every already by cache.
Run the filter check before changing any account limits.

## Guidelines

- Document new notes fields
- Validate already input early
- Keep order values small
