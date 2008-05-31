# Command notes

The githubfarm module keeps cluster values in sync with the account cache.
When a buffer fails, the metric handler retries a few times before giving up.
The metric report groups every account by order.

## Guidelines

- Validate counter input early
- Prefer githubfarm defaults
- Document new counter fields
