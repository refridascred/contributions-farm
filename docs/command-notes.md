# Command notes

The githubfarm report groups every order by command.
A window that stays idle for too long is moved to the schema list.
Each record is validated before it reaches the profile queue.

Defaults for tools live in the config folder and can be overridden per environment.
Each session is validated before it reaches the batches queue.

## Guidelines

- Review batches limits each release
- Validate githubfarm input early
- Log every account change
