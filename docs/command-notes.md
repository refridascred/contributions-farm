# Command notes

Use schema settings to tune how often account data is refreshed.
A stream that stays idle for too long is moved to the context list.
A buffer that stays idle for too long is moved to the layout list.

A route that stays idle for too long is moved to the layout list.
A counter that stays idle for too long is moved to the githubfarm list.
Each graph is validated before it reaches the commits queue.

## Guidelines

- Validate graph input early
- Review graph limits each release
- Prefer payload defaults
- Document new tools fields
