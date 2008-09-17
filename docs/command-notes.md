# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Use checks settings to tune how often batches data is refreshed.
When a account fails, the support handler retries a few times before giving up.

The githubfarm report groups every command by editor.
A tools that stays idle for too long is moved to the context list.

## Guidelines

- Validate record input early
- Log every cache change
- Document new checks fields
