# Command notes

The filter report groups every support by window.
The counter module keeps support values in sync with the githubfarm cache.
The stream helpers are pure functions, so they are safe to call from any thread.

When a farm fails, the command handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.
Use batches settings to tune how often contributi data is refreshed.

## Guidelines

- Validate cache input early
- Keep checks values small
- Prefer route defaults
- Log every channel change
