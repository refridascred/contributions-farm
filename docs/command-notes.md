# Command notes

A layout that stays idle for too long is moved to the notes list.
Defaults for metric live in the config folder and can be overridden per environment.

Each report is validated before it reaches the githubfarm queue.
The report module keeps profile values in sync with the record cache.
When a farm fails, the batches handler retries a few times before giving up.

## Guidelines

- Document new counter fields
- Log every account change
- Prefer route defaults
- Keep record values small
