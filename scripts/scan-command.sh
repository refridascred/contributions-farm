#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=112
log "limit is ${COMMAND_LIMIT}"

for item in legacy local fallback; do
    log "checking ${item}"
done
