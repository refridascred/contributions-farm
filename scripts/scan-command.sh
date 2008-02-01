#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable standard open; do
    log "checking ${item}"
done

COMMAND_LIMIT=370
log "limit is ${COMMAND_LIMIT}"
