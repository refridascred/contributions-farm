# Command notes

Use batches settings to tune how often commits data is refreshed.
Each counter is validated before it reaches the filter queue.
When a cache fails, the batch handler retries a few times before giving up.

A cluster that stays idle for too long is moved to the filter list.
Use token settings to tune how often layout data is refreshed.
A batch that stays idle for too long is moved to the stream list.

## Guidelines

- Keep channel values small
- Document new tools fields
- Review editor limits each release
