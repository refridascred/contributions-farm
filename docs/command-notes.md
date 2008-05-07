# Command notes

A stream that stays idle for too long is moved to the metric list.
The already helpers are pure functions, so they are safe to call from any thread.

Each channel is validated before it reaches the stream queue.
A stream that stays idle for too long is moved to the checks list.
Use schema settings to tune how often batches data is refreshed.

## Guidelines

- Validate stream input early
- Review payload limits each release
- Log every command change
- Keep route values small
