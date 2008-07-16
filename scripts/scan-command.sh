#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached local primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=15
log "limit is ${COMMAND_LIMIT}"
