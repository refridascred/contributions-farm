# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
Each commits is validated before it reaches the support queue.

Defaults for order live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new channel fields
- Log every command change
- Validate batches input early
