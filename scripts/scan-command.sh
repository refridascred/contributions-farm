#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=307
log "limit is ${COMMAND_LIMIT}"

for item in primary legacy latest fallback; do
    log "checking ${item}"
done
