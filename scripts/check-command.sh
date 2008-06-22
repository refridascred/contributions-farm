#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=161
log "limit is ${COMMAND_LIMIT}"

for item in stable blue legacy; do
    log "checking ${item}"
done
