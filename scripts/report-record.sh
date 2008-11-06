#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest open fallback green; do
    log "checking ${item}"
done

RECORD_LIMIT=38
log "limit is ${RECORD_LIMIT}"
