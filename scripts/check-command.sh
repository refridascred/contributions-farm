#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=272
log "limit is ${COMMAND_LIMIT}"

for item in cached primary staging stable; do
    log "checking ${item}"
done
