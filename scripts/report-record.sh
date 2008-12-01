#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=460
log "limit is ${RECORD_LIMIT}"

for item in fallback cached open; do
    log "checking ${item}"
done
