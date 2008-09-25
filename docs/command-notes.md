# Command notes

The token module keeps farm values in sync with the record cache.
A stream that stays idle for too long is moved to the account list.
Use notes settings to tune how often schema data is refreshed.

Use cache settings to tune how often record data is refreshed.
The format module keeps queue values in sync with the githubfarm cache.
Each commits is validated before it reaches the contributi queue.

## Guidelines

- Prefer stats defaults
- Log every report change
- Validate batch input early
- Keep metrics values small
