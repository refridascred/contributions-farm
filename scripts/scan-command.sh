#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=171
log "limit is ${COMMAND_LIMIT}"

for item in open stable standard fallback; do
    log "checking ${item}"
done
