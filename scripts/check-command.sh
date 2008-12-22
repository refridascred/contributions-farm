#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=324
log "limit is ${COMMAND_LIMIT}"

for item in legacy latest eu-west open; do
    log "checking ${item}"
done
