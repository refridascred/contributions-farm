#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard edge cached local; do
    log "checking ${item}"
done

RECORD_LIMIT=335
log "limit is ${RECORD_LIMIT}"
