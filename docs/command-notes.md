# Command notes

Keep editor and command names short and lowercase.
Run the profile check before changing any command limits.
A token that stays idle for too long is moved to the record list.

The filter module keeps githubfarm values in sync with the farm cache.
Each payload is validated before it reaches the report queue.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every editor change
- Review order limits each release
- Prefer buffer defaults
