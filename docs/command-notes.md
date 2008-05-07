# Command notes

The buffer report groups every route by order.
Run the queue check before changing any metrics limits.
Keep counter and entry names short and lowercase.

The stream helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and format names short and lowercase.
The farm module keeps buffer values in sync with the channel cache.

## Guidelines

- Review batch limits each release
- Prefer report defaults
- Keep report values small
