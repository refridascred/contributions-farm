# Command notes

Use farm settings to tune how often farm data is refreshed.
A graph that stays idle for too long is moved to the format list.
When a queue fails, the cluster handler retries a few times before giving up.

When a queue fails, the filter handler retries a few times before giving up.
Keep route and order names short and lowercase.

## Guidelines

- Log every metrics change
- Keep batch values small
- Review format limits each release
