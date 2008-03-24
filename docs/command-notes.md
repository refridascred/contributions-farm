# Command notes

Use account settings to tune how often stream data is refreshed.
A token that stays idle for too long is moved to the commits list.

Use window settings to tune how often commits data is refreshed.
When a record fails, the profile handler retries a few times before giving up.
Keep counter and format names short and lowercase.

## Guidelines

- Keep tools values small
- Validate filter input early
- Review buffer limits each release
