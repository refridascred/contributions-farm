#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging green; do
    log "checking ${item}"
done

RECORD_LIMIT=174
log "limit is ${RECORD_LIMIT}"
