#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=289
log "limit is ${COMMAND_LIMIT}"

for item in local standard green cached; do
    log "checking ${item}"
done
