# Command notes

Run the cache check before changing any metrics limits.
Each layout is validated before it reaches the batches queue.

A window that stays idle for too long is moved to the session list.
Defaults for metrics live in the config folder and can be overridden per environment.
Each checks is validated before it reaches the batch queue.

## Guidelines

- Review schema limits each release
- Prefer commits defaults
- Document new context fields
- Keep format values small
