#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=144
log "limit is ${COMMAND_LIMIT}"

for item in standard green; do
    log "checking ${item}"
done
