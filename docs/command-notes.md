# Command notes

Run the channel check before changing any checks limits.
Defaults for githubfarm live in the config folder and can be overridden per environment.

The layout module keeps context values in sync with the githubfarm cache.
When a schema fails, the order handler retries a few times before giving up.
Keep window and githubfarm names short and lowercase.

## Guidelines

- Log every layout change
- Keep window values small
- Validate support input early
- Document new tools fields
