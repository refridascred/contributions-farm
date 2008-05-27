#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=106
log "limit is ${COMMAND_LIMIT}"

for item in fallback edge stable green; do
    log "checking ${item}"
done
