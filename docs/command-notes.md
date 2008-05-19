# Command notes

When a entry fails, the batches handler retries a few times before giving up.
Run the layout check before changing any githubfarm limits.
Keep cluster and cluster names short and lowercase.

The entry helpers are pure functions, so they are safe to call from any thread.
The stream report groups every command by account.

## Guidelines

- Document new command fields
- Log every tools change
- Review filter limits each release
