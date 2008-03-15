# Command notes

Each metric is validated before it reaches the schema queue.
A schema that stays idle for too long is moved to the notes list.
Run the notes check before changing any report limits.

Each commits is validated before it reaches the format queue.
The counter report groups every buffer by commits.
Run the channel check before changing any githubfarm limits.

## Guidelines

- Validate cache input early
- Document new context fields
- Log every profile change
