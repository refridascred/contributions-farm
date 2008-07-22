#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=312
log "limit is ${COMMAND_LIMIT}"

for item in primary eu-west; do
    log "checking ${item}"
done
