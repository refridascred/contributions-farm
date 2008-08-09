#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=446
log "limit is ${COMMAND_LIMIT}"

for item in latest cached staging fallback; do
    log "checking ${item}"
done
