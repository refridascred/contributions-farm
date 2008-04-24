#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback local staging; do
    log "checking ${item}"
done

RECORD_LIMIT=365
log "limit is ${RECORD_LIMIT}"
