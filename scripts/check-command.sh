#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable legacy green; do
    log "checking ${item}"
done

COMMAND_LIMIT=251
log "limit is ${COMMAND_LIMIT}"
