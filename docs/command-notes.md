# Command notes

Run the cluster check before changing any context limits.
When a commits fails, the layout handler retries a few times before giving up.

When a format fails, the queue handler retries a few times before giving up.
The tools module keeps channel values in sync with the already cache.
Keep report and metric names short and lowercase.

## Guidelines

- Log every channel change
- Keep record values small
- Prefer window defaults
- Review editor limits each release
