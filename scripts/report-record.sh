#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=91
log "limit is ${RECORD_LIMIT}"

for item in local eu-west primary; do
    log "checking ${item}"
done
