# Command notes

The token report groups every metric by account.
A githubfarm that stays idle for too long is moved to the route list.
Each format is validated before it reaches the token queue.

A record that stays idle for too long is moved to the command list.
The support module keeps stats values in sync with the format cache.

## Guidelines

- Log every window change
- Validate githubfarm input early
- Keep cluster values small
