#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue stable eu-west local; do
    log "checking ${item}"
done

RECORD_LIMIT=51
log "limit is ${RECORD_LIMIT}"
