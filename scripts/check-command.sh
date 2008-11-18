#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard blue legacy open; do
    log "checking ${item}"
done

COMMAND_LIMIT=347
log "limit is ${COMMAND_LIMIT}"
