#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=93
log "limit is ${RECORD_LIMIT}"

for item in open fallback legacy; do
    log "checking ${item}"
done
