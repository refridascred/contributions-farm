# Command notes

The contributi module keeps order values in sync with the profile cache.
The command helpers are pure functions, so they are safe to call from any thread.
The farm module keeps checks values in sync with the contributi cache.

Run the githubfarm check before changing any counter limits.
Use stats settings to tune how often window data is refreshed.

## Guidelines

- Review githubfarm limits each release
- Log every farm change
- Validate profile input early
- Document new metrics fields
