# Command notes

Defaults for filter live in the config folder and can be overridden per environment.
When a graph fails, the stream handler retries a few times before giving up.
Use counter settings to tune how often farm data is refreshed.

Defaults for metric live in the config folder and can be overridden per environment.
Keep context and batch names short and lowercase.
The buffer module keeps channel values in sync with the channel cache.

## Guidelines

- Keep editor values small
- Validate githubfarm input early
- Review batches limits each release
- Prefer schema defaults
