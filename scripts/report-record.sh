#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=420
log "limit is ${RECORD_LIMIT}"

for item in edge cached; do
    log "checking ${item}"
done
