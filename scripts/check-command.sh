#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue edge eu-west stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=196
log "limit is ${COMMAND_LIMIT}"
