#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=292
log "limit is ${RECORD_LIMIT}"

for item in fallback open; do
    log "checking ${item}"
done
