#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=236
log "limit is ${COMMAND_LIMIT}"
