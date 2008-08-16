#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open eu-west blue; do
    log "checking ${item}"
done

RECORD_LIMIT=477
log "limit is ${RECORD_LIMIT}"
