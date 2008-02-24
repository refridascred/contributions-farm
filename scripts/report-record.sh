#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=83
log "limit is ${RECORD_LIMIT}"

for item in green blue staging latest; do
    log "checking ${item}"
done
