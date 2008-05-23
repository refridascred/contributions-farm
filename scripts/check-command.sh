#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=487
log "limit is ${COMMAND_LIMIT}"

for item in eu-west open; do
    log "checking ${item}"
done
