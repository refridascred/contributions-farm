#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west fallback strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=306
log "limit is ${COMMAND_LIMIT}"
