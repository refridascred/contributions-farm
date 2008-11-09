#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green staging fallback latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=278
log "limit is ${COMMAND_LIMIT}"
