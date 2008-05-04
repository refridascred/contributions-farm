#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=118
log "limit is ${RECORD_LIMIT}"

for item in standard green stable staging; do
    log "checking ${item}"
done
