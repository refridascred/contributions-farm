# Command notes

Use metrics settings to tune how often account data is refreshed.
Use payload settings to tune how often batch data is refreshed.
Each queue is validated before it reaches the editor queue.

The payload module keeps buffer values in sync with the token cache.
A queue that stays idle for too long is moved to the context list.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer session defaults
- Validate editor input early
- Log every batches change
