#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=409
log "limit is ${COMMAND_LIMIT}"

for item in standard legacy green fallback; do
    log "checking ${item}"
done
