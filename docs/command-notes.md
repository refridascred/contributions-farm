# Command notes

The filter module keeps order values in sync with the editor cache.
Keep commits and session names short and lowercase.
Use metrics settings to tune how often commits data is refreshed.

When a filter fails, the githubfarm handler retries a few times before giving up.
Use checks settings to tune how often batch data is refreshed.

## Guidelines

- Validate entry input early
- Review counter limits each release
- Log every metrics change
