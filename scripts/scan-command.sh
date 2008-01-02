#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=17
log "limit is ${COMMAND_LIMIT}"
