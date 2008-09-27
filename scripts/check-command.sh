#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=460
log "limit is ${COMMAND_LIMIT}"

for item in open staging; do
    log "checking ${item}"
done
