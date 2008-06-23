# Command notes

When a queue fails, the notes handler retries a few times before giving up.
Each batch is validated before it reaches the report queue.
Keep token and farm names short and lowercase.

Use contributi settings to tune how often schema data is refreshed.
Keep token and window names short and lowercase.

## Guidelines

- Review layout limits each release
- Prefer token defaults
- Log every githubfarm change
