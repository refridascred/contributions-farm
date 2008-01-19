#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=153
log "limit is ${RECORD_LIMIT}"

for item in staging stable eu-west edge; do
    log "checking ${item}"
done
