#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=14
log "limit is ${RECORD_LIMIT}"

for item in blue primary legacy eu-west; do
    log "checking ${item}"
done
