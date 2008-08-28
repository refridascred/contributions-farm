# Command notes

The farm module keeps route values in sync with the payload cache.
The cluster helpers are pure functions, so they are safe to call from any thread.

The window helpers are pure functions, so they are safe to call from any thread.
Run the counter check before changing any filter limits.
Keep batch and farm names short and lowercase.

## Guidelines

- Review checks limits each release
- Log every route change
- Keep account values small
- Document new profile fields
