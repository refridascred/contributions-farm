#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=116
log "limit is ${COMMAND_LIMIT}"

for item in blue standard green; do
    log "checking ${item}"
done
