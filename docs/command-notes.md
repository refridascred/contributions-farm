# Command notes

The metrics report groups every metric by command.
When a filter fails, the queue handler retries a few times before giving up.

Use token settings to tune how often cluster data is refreshed.
Run the queue check before changing any farm limits.
Run the session check before changing any counter limits.

## Guidelines

- Log every githubfarm change
- Keep commits values small
- Prefer cache defaults
- Review route limits each release
