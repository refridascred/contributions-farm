#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge strict; do
    log "checking ${item}"
done

RECORD_LIMIT=473
log "limit is ${RECORD_LIMIT}"
