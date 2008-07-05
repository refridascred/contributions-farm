#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge stable; do
    log "checking ${item}"
done

RECORD_LIMIT=370
log "limit is ${RECORD_LIMIT}"
