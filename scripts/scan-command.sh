#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=452
log "limit is ${COMMAND_LIMIT}"

for item in green eu-west staging fallback; do
    log "checking ${item}"
done
