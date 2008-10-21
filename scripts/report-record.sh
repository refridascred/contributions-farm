#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open cached standard local; do
    log "checking ${item}"
done

RECORD_LIMIT=69
log "limit is ${RECORD_LIMIT}"
