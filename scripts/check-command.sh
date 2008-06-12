#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=120
log "limit is ${COMMAND_LIMIT}"
