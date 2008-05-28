# Command notes

Keep payload and githubfarm names short and lowercase.
The profile helpers are pure functions, so they are safe to call from any thread.
A command that stays idle for too long is moved to the metrics list.

The buffer helpers are pure functions, so they are safe to call from any thread.
Use batches settings to tune how often metrics data is refreshed.

## Guidelines

- Validate stream input early
- Review notes limits each release
- Keep notes values small
