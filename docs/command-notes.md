# Command notes

A cluster that stays idle for too long is moved to the githubfarm list.
Use checks settings to tune how often batch data is refreshed.

The token report groups every checks by commits.
When a context fails, the command handler retries a few times before giving up.

## Guidelines

- Prefer stream defaults
- Review stream limits each release
- Document new payload fields
- Keep checks values small
