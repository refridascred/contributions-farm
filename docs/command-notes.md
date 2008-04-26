# Command notes

The metrics module keeps format values in sync with the filter cache.
The githubfarm module keeps report values in sync with the order cache.
Keep githubfarm and report names short and lowercase.

When a layout fails, the stream handler retries a few times before giving up.
A entry that stays idle for too long is moved to the checks list.
Use batches settings to tune how often account data is refreshed.

## Guidelines

- Validate profile input early
- Review githubfarm limits each release
- Document new support fields
- Prefer support defaults
