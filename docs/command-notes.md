# Command notes

Run the githubfarm check before changing any session limits.
A account that stays idle for too long is moved to the command list.
Each stream is validated before it reaches the cluster queue.

Keep counter and buffer names short and lowercase.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every already change
- Document new metrics fields
- Validate cluster input early
