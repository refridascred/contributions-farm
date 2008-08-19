#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=275
log "limit is ${RECORD_LIMIT}"

for item in cached strict green; do
    log "checking ${item}"
done
