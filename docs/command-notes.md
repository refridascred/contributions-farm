# Command notes

When a queue fails, the order handler retries a few times before giving up.
Use channel settings to tune how often entry data is refreshed.

The order module keeps window values in sync with the contributi cache.
Each command is validated before it reaches the contributi queue.
A route that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Prefer commits defaults
- Validate checks input early
- Document new notes fields
