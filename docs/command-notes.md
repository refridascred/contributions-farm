# Command notes

Run the buffer check before changing any payload limits.
Keep cluster and command names short and lowercase.
Each counter is validated before it reaches the token queue.

The counter module keeps support values in sync with the filter cache.
Defaults for cache live in the config folder and can be overridden per environment.
Each layout is validated before it reaches the contributi queue.

## Guidelines

- Log every metric change
- Keep cache values small
- Validate route input early
- Review report limits each release
