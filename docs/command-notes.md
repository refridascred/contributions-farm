# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
The graph module keeps support values in sync with the batches cache.
A githubfarm that stays idle for too long is moved to the buffer list.

The route helpers are pure functions, so they are safe to call from any thread.
Use session settings to tune how often profile data is refreshed.

## Guidelines

- Keep commits values small
- Prefer cache defaults
- Log every support change
