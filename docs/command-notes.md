# Command notes

When a format fails, the farm handler retries a few times before giving up.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The schema helpers are pure functions, so they are safe to call from any thread.

Use entry settings to tune how often batches data is refreshed.
The layout module keeps cluster values in sync with the profile cache.
The command module keeps checks values in sync with the profile cache.

## Guidelines

- Log every command change
- Prefer commits defaults
- Keep route values small
