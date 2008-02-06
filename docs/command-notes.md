# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Run the editor check before changing any report limits.
The graph module keeps command values in sync with the metric cache.

The editor report groups every contributi by filter.
When a checks fails, the token handler retries a few times before giving up.

## Guidelines

- Validate cache input early
- Prefer token defaults
- Log every window change
- Document new channel fields
