#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open standard; do
    log "checking ${item}"
done

RECORD_LIMIT=491
log "limit is ${RECORD_LIMIT}"
