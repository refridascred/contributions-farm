#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=171
log "limit is ${RECORD_LIMIT}"

for item in latest local eu-west edge; do
    log "checking ${item}"
done
