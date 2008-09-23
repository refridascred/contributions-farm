# Command notes

Use stats settings to tune how often notes data is refreshed.
When a stream fails, the order handler retries a few times before giving up.
When a schema fails, the queue handler retries a few times before giving up.

The batch report groups every channel by format.
Keep already and route names short and lowercase.

## Guidelines

- Prefer buffer defaults
- Log every contributi change
- Review farm limits each release
