#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=430
log "limit is ${COMMAND_LIMIT}"

for item in open standard green; do
    log "checking ${item}"
done
