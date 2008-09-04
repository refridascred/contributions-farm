#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=316
log "limit is ${COMMAND_LIMIT}"

for item in local staging; do
    log "checking ${item}"
done
