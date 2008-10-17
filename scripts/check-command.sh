#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging open eu-west edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=232
log "limit is ${COMMAND_LIMIT}"
