# Command notes

Use schema settings to tune how often format data is refreshed.
Each batch is validated before it reaches the record queue.
A format that stays idle for too long is moved to the metric list.

## Guidelines

- Log every route change
- Prefer batch defaults
- Validate channel input early
- Keep contributi values small
