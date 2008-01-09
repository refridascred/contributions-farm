# Command notes

Use account settings to tune how often payload data is refreshed.
A command that stays idle for too long is moved to the githubfarm list.
A payload that stays idle for too long is moved to the checks list.

Use checks settings to tune how often cluster data is refreshed.
The cache report groups every stats by layout.

## Guidelines

- Review token limits each release
- Keep stats values small
- Log every entry change
- Validate stream input early
