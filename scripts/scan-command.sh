#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict edge fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=245
log "limit is ${COMMAND_LIMIT}"
