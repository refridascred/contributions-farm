#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging fallback local cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=276
log "limit is ${COMMAND_LIMIT}"
