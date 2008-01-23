# Command notes

Run the filter check before changing any buffer limits.
Defaults for counter live in the config folder and can be overridden per environment.
Each batch is validated before it reaches the githubfarm queue.

Use route settings to tune how often format data is refreshed.
A token that stays idle for too long is moved to the channel list.
A counter that stays idle for too long is moved to the stats list.

## Guidelines

- Review filter limits each release
- Validate session input early
- Keep batches values small
