#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=239
log "limit is ${COMMAND_LIMIT}"

for item in cached strict open; do
    log "checking ${item}"
done
