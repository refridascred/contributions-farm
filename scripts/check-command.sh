#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable cached strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=309
log "limit is ${COMMAND_LIMIT}"
