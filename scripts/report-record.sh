#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=145
log "limit is ${RECORD_LIMIT}"

for item in latest fallback local; do
    log "checking ${item}"
done
