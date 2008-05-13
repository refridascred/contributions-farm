#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable cached legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=431
log "limit is ${RECORD_LIMIT}"
