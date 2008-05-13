#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=257
log "limit is ${RECORD_LIMIT}"

for item in legacy latest; do
    log "checking ${item}"
done
