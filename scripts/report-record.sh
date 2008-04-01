#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard green staging stable; do
    log "checking ${item}"
done

RECORD_LIMIT=25
log "limit is ${RECORD_LIMIT}"
