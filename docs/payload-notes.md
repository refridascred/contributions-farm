# Payload notes

Run the record check before changing any batches limits.
Each counter is validated before it reaches the account queue.

The stream helpers are pure functions, so they are safe to call from any thread.
Keep context and stream names short and lowercase.
Each context is validated before it reaches the githubfarm queue.

## Guidelines

- Document new account fields
- Prefer commits defaults
- Review checks limits each release
