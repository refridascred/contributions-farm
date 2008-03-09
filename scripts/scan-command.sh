#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback cached primary green; do
    log "checking ${item}"
done

COMMAND_LIMIT=9
log "limit is ${COMMAND_LIMIT}"
