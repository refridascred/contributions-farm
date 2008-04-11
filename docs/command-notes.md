# Command notes

Each record is validated before it reaches the editor queue.
Use metrics settings to tune how often context data is refreshed.
Defaults for buffer live in the config folder and can be overridden per environment.

Defaults for already live in the config folder and can be overridden per environment.
When a batch fails, the report handler retries a few times before giving up.
The payload report groups every queue by window.

## Guidelines

- Prefer cache defaults
- Document new counter fields
- Keep buffer values small
