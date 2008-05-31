#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback legacy blue stable; do
    log "checking ${item}"
done

RECORD_LIMIT=114
log "limit is ${RECORD_LIMIT}"
