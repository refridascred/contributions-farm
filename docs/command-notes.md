# Command notes

When a queue fails, the buffer handler retries a few times before giving up.
When a stats fails, the channel handler retries a few times before giving up.
Run the route check before changing any graph limits.

The payload report groups every githubfarm by window.
Use commits settings to tune how often commits data is refreshed.
Keep checks and filter names short and lowercase.

## Guidelines

- Keep stream values small
- Review channel limits each release
- Log every token change
