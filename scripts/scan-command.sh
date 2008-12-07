#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging fallback strict legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=68
log "limit is ${COMMAND_LIMIT}"
