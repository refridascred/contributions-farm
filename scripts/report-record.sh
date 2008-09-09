#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=383
log "limit is ${RECORD_LIMIT}"

for item in stable latest open primary; do
    log "checking ${item}"
done
