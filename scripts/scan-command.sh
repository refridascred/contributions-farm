#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue standard strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=287
log "limit is ${COMMAND_LIMIT}"
