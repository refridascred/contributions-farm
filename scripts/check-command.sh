#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=381
log "limit is ${COMMAND_LIMIT}"

for item in legacy green primary stable; do
    log "checking ${item}"
done
