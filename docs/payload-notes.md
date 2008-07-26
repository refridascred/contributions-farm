# Payload notes

The editor report groups every metrics by token.
Use report settings to tune how often entry data is refreshed.
A contributi that stays idle for too long is moved to the githubfarm list.

A layout that stays idle for too long is moved to the batches list.
Defaults for command live in the config folder and can be overridden per environment.
When a route fails, the stats handler retries a few times before giving up.

## Guidelines

- Keep filter values small
- Document new contributi fields
- Validate cache input early
- Log every context change
