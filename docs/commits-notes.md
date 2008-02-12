# Commits notes

The tools module keeps already values in sync with the counter cache.
When a entry fails, the queue handler retries a few times before giving up.
The context helpers are pure functions, so they are safe to call from any thread.

A buffer that stays idle for too long is moved to the window list.
Use githubfarm settings to tune how often farm data is refreshed.
Run the stream check before changing any layout limits.

## Guidelines

- Document new contributi fields
- Prefer cache defaults
- Validate channel input early
- Keep account values small
