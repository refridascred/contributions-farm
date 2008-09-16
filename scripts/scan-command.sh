#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west stable blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=5
log "limit is ${COMMAND_LIMIT}"
