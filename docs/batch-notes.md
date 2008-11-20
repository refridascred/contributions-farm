# Batch notes

Run the queue check before changing any stream limits.
When a metric fails, the tools handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.

A already that stays idle for too long is moved to the metrics list.
Each profile is validated before it reaches the editor queue.
Run the githubfarm check before changing any cluster limits.

## Guidelines

- Review contributi limits each release
- Log every queue change
- Keep editor values small
