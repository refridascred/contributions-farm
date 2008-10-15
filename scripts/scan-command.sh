#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=456
log "limit is ${COMMAND_LIMIT}"

for item in fallback primary latest; do
    log "checking ${item}"
done
