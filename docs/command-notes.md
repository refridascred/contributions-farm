# Command notes

When a stream fails, the report handler retries a few times before giving up.
The token module keeps command values in sync with the contributi cache.
Keep githubfarm and cache names short and lowercase.

Use route settings to tune how often queue data is refreshed.
A filter that stays idle for too long is moved to the batch list.
A report that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Log every route change
- Prefer batch defaults
- Keep context values small
