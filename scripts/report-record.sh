#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=383
log "limit is ${RECORD_LIMIT}"

for item in edge strict primary legacy; do
    log "checking ${item}"
done
