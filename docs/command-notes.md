# Command notes

Keep githubfarm and notes names short and lowercase.
Defaults for cluster live in the config folder and can be overridden per environment.
Each profile is validated before it reaches the route queue.

When a checks fails, the contributi handler retries a few times before giving up.
When a queue fails, the counter handler retries a few times before giving up.
The tools module keeps context values in sync with the editor cache.

## Guidelines

- Review support limits each release
- Keep farm values small
- Validate cluster input early
- Prefer report defaults
