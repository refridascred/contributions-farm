#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=225
log "limit is ${COMMAND_LIMIT}"

for item in blue standard fallback latest; do
    log "checking ${item}"
done
