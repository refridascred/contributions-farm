#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west local edge; do
    log "checking ${item}"
done

RECORD_LIMIT=235
log "limit is ${RECORD_LIMIT}"
