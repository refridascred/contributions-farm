# Commits notes

The command report groups every queue by batches.
When a report fails, the cache handler retries a few times before giving up.

Keep account and layout names short and lowercase.
When a profile fails, the account handler retries a few times before giving up.
Use token settings to tune how often cache data is refreshed.

## Guidelines

- Keep tools values small
- Validate entry input early
- Log every profile change
- Prefer githubfarm defaults
