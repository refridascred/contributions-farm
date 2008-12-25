#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=270
log "limit is ${COMMAND_LIMIT}"

for item in fallback legacy green; do
    log "checking ${item}"
done
