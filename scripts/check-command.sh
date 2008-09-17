#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable eu-west strict open; do
    log "checking ${item}"
done

COMMAND_LIMIT=109
log "limit is ${COMMAND_LIMIT}"
