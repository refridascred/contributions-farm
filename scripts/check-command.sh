#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy open staging local; do
    log "checking ${item}"
done

COMMAND_LIMIT=363
log "limit is ${COMMAND_LIMIT}"
