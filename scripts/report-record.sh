#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=395
log "limit is ${RECORD_LIMIT}"

for item in fallback legacy strict; do
    log "checking ${item}"
done
