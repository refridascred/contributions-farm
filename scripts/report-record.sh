#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=44
log "limit is ${RECORD_LIMIT}"

for item in open standard legacy blue; do
    log "checking ${item}"
done
