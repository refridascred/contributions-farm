#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west edge open stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=304
log "limit is ${COMMAND_LIMIT}"
