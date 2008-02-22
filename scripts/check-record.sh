#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=21
log "limit is ${RECORD_LIMIT}"

for item in open blue latest; do
    log "checking ${item}"
done
