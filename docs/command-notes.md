# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
The filter module keeps graph values in sync with the support cache.

Use support settings to tune how often route data is refreshed.
A stats that stays idle for too long is moved to the stats list.
The account module keeps editor values in sync with the order cache.

## Guidelines

- Document new buffer fields
- Keep support values small
- Prefer format defaults
