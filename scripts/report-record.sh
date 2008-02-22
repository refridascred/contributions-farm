#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open staging local blue; do
    log "checking ${item}"
done

RECORD_LIMIT=298
log "limit is ${RECORD_LIMIT}"
