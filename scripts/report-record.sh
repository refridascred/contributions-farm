#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary latest strict; do
    log "checking ${item}"
done

RECORD_LIMIT=468
log "limit is ${RECORD_LIMIT}"
