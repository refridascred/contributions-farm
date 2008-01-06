#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=232
log "limit is ${COMMAND_LIMIT}"

for item in strict blue edge; do
    log "checking ${item}"
done
