#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary fallback local green; do
    log "checking ${item}"
done

COMMAND_LIMIT=139
log "limit is ${COMMAND_LIMIT}"
