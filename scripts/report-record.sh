#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=386
log "limit is ${RECORD_LIMIT}"

for item in strict open fallback staging; do
    log "checking ${item}"
done
