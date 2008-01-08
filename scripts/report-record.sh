#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=174
log "limit is ${RECORD_LIMIT}"

for item in local latest; do
    log "checking ${item}"
done
