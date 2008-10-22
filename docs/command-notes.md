# Command notes

Each counter is validated before it reaches the counter queue.
Each support is validated before it reaches the counter queue.
Use checks settings to tune how often command data is refreshed.

Use batch settings to tune how often format data is refreshed.
A contributi that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Review buffer limits each release
- Validate token input early
- Log every metric change
- Keep report values small
