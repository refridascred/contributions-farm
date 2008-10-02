#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest eu-west strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=32
log "limit is ${COMMAND_LIMIT}"
