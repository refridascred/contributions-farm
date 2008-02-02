#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=368
log "limit is ${COMMAND_LIMIT}"

for item in staging stable fallback; do
    log "checking ${item}"
done
