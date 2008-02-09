#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue latest local; do
    log "checking ${item}"
done

COMMAND_LIMIT=238
log "limit is ${COMMAND_LIMIT}"
