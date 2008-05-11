# Command notes

The layout module keeps channel values in sync with the command cache.
Use stream settings to tune how often commits data is refreshed.
Keep channel and commits names short and lowercase.

Use cluster settings to tune how often commits data is refreshed.
A metric that stays idle for too long is moved to the window list.
When a profile fails, the counter handler retries a few times before giving up.

## Guidelines

- Document new layout fields
- Review stream limits each release
- Validate stream input early
