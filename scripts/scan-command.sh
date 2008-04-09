#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard latest fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=61
log "limit is ${COMMAND_LIMIT}"
