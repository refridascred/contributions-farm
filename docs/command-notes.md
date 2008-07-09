# Command notes

Use metrics settings to tune how often window data is refreshed.
Use githubfarm settings to tune how often session data is refreshed.
Keep tools and layout names short and lowercase.

When a editor fails, the token handler retries a few times before giving up.
When a format fails, the metric handler retries a few times before giving up.
Each stream is validated before it reaches the cluster queue.

## Guidelines

- Validate stats input early
- Prefer commits defaults
- Log every support change
