#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=143
log "limit is ${RECORD_LIMIT}"

for item in open fallback legacy latest; do
    log "checking ${item}"
done
