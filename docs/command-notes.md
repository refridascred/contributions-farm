# Command notes

The commits module keeps contributi values in sync with the support cache.
When a payload fails, the buffer handler retries a few times before giving up.

Use githubfarm settings to tune how often token data is refreshed.
Use cache settings to tune how often payload data is refreshed.
The tools module keeps metric values in sync with the filter cache.

## Guidelines

- Keep payload values small
- Validate cluster input early
- Prefer order defaults
