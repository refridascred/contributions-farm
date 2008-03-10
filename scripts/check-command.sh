#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open cached local; do
    log "checking ${item}"
done

COMMAND_LIMIT=104
log "limit is ${COMMAND_LIMIT}"
