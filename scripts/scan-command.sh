#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary staging local; do
    log "checking ${item}"
done

COMMAND_LIMIT=355
log "limit is ${COMMAND_LIMIT}"
