#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=90
log "limit is ${COMMAND_LIMIT}"

for item in fallback staging eu-west blue; do
    log "checking ${item}"
done
