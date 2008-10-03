# Command notes

The payload module keeps route values in sync with the batches cache.
When a metrics fails, the queue handler retries a few times before giving up.

Each tools is validated before it reaches the tools queue.
Use context settings to tune how often record data is refreshed.
A notes that stays idle for too long is moved to the profile list.

## Guidelines

- Log every metrics change
- Prefer profile defaults
- Validate notes input early
- Keep cluster values small
