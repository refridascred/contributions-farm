#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging blue edge eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=184
log "limit is ${RECORD_LIMIT}"
