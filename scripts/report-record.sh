#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest fallback edge; do
    log "checking ${item}"
done

RECORD_LIMIT=187
log "limit is ${RECORD_LIMIT}"
