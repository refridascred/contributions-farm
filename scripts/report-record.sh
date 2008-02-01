#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=180
log "limit is ${RECORD_LIMIT}"

for item in latest strict; do
    log "checking ${item}"
done
