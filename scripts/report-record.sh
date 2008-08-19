#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=95
log "limit is ${RECORD_LIMIT}"

for item in edge local latest stable; do
    log "checking ${item}"
done
