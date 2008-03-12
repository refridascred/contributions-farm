#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=258
log "limit is ${RECORD_LIMIT}"

for item in stable latest green; do
    log "checking ${item}"
done
