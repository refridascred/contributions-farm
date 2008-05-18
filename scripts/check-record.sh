#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=245
log "limit is ${RECORD_LIMIT}"
