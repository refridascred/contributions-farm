#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=182
log "limit is ${COMMAND_LIMIT}"

for item in standard primary open fallback; do
    log "checking ${item}"
done
