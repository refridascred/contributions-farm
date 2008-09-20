# Command notes

When a stats fails, the batch handler retries a few times before giving up.
The githubfarm module keeps format values in sync with the window cache.
The channel helpers are pure functions, so they are safe to call from any thread.

Use farm settings to tune how often cluster data is refreshed.
Keep farm and contributi names short and lowercase.
Use stream settings to tune how often stats data is refreshed.

## Guidelines

- Document new command fields
- Review filter limits each release
- Log every profile change
