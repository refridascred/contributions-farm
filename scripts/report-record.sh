#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback cached green; do
    log "checking ${item}"
done

RECORD_LIMIT=423
log "limit is ${RECORD_LIMIT}"
