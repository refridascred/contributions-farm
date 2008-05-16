#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging cached legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=484
log "limit is ${RECORD_LIMIT}"
