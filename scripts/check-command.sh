#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=209
log "limit is ${COMMAND_LIMIT}"

for item in staging latest eu-west primary; do
    log "checking ${item}"
done
