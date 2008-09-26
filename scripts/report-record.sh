#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest blue; do
    log "checking ${item}"
done

RECORD_LIMIT=77
log "limit is ${RECORD_LIMIT}"
