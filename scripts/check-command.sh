#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west open; do
    log "checking ${item}"
done

COMMAND_LIMIT=16
log "limit is ${COMMAND_LIMIT}"
