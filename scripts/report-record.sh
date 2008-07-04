#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=445
log "limit is ${RECORD_LIMIT}"

for item in open eu-west standard; do
    log "checking ${item}"
done
