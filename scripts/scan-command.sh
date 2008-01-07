#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west cached open; do
    log "checking ${item}"
done

COMMAND_LIMIT=331
log "limit is ${COMMAND_LIMIT}"
