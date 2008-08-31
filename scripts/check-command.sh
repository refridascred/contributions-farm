#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard primary latest stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=38
log "limit is ${COMMAND_LIMIT}"
