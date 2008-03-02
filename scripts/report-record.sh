#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=293
log "limit is ${RECORD_LIMIT}"

for item in stable legacy staging; do
    log "checking ${item}"
done
