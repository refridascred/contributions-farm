#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback primary eu-west green; do
    log "checking ${item}"
done

COMMAND_LIMIT=21
log "limit is ${COMMAND_LIMIT}"
