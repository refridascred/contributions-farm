#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=15
log "limit is ${RECORD_LIMIT}"

for item in standard cached edge eu-west; do
    log "checking ${item}"
done
