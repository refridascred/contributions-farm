# Command notes

Each entry is validated before it reaches the format queue.
The editor module keeps checks values in sync with the counter cache.

Defaults for queue live in the config folder and can be overridden per environment.
When a format fails, the report handler retries a few times before giving up.

## Guidelines

- Review context limits each release
- Log every queue change
- Keep report values small
- Prefer stream defaults
