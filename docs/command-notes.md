# Command notes

A notes that stays idle for too long is moved to the githubfarm list.
When a checks fails, the cluster handler retries a few times before giving up.

The profile helpers are pure functions, so they are safe to call from any thread.
Use batches settings to tune how often filter data is refreshed.

## Guidelines

- Keep checks values small
- Validate tools input early
- Prefer metric defaults
- Log every githubfarm change
