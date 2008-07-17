#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=313
log "limit is ${RECORD_LIMIT}"

for item in green staging strict fallback; do
    log "checking ${item}"
done
