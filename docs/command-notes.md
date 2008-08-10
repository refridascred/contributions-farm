# Command notes

Keep filter and payload names short and lowercase.
Each context is validated before it reaches the account queue.
When a farm fails, the githubfarm handler retries a few times before giving up.

A githubfarm that stays idle for too long is moved to the commits list.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cache limits each release
- Log every queue change
- Document new profile fields
