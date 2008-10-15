#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict fallback staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=296
log "limit is ${COMMAND_LIMIT}"
