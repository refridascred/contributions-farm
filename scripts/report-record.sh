#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict green fallback cached; do
    log "checking ${item}"
done

RECORD_LIMIT=366
log "limit is ${RECORD_LIMIT}"
