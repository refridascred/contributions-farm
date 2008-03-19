#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=238
log "limit is ${RECORD_LIMIT}"

for item in stable primary cached eu-west; do
    log "checking ${item}"
done
