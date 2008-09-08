# Command notes

Each batches is validated before it reaches the layout queue.
The record helpers are pure functions, so they are safe to call from any thread.

Each payload is validated before it reaches the account queue.
Defaults for cluster live in the config folder and can be overridden per environment.
When a record fails, the account handler retries a few times before giving up.

## Guidelines

- Document new metrics fields
- Review filter limits each release
- Log every buffer change
- Prefer contributi defaults
