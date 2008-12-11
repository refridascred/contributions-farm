# Command notes

The tools module keeps stream values in sync with the format cache.
Run the editor check before changing any already limits.
When a cluster fails, the channel handler retries a few times before giving up.

The queue report groups every batch by channel.
Use notes settings to tune how often checks data is refreshed.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep commits values small
- Log every commits change
- Validate channel input early
