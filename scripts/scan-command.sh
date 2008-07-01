#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=190
log "limit is ${COMMAND_LIMIT}"

for item in staging standard edge; do
    log "checking ${item}"
done
