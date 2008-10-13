#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard fallback primary green; do
    log "checking ${item}"
done

RECORD_LIMIT=26
log "limit is ${RECORD_LIMIT}"
