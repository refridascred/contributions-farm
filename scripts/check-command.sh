#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=400
log "limit is ${COMMAND_LIMIT}"

for item in fallback eu-west strict; do
    log "checking ${item}"
done
