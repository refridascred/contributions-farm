#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=5
log "limit is ${COMMAND_LIMIT}"

for item in primary eu-west blue stable; do
    log "checking ${item}"
done
