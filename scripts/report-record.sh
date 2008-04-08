#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=399
log "limit is ${RECORD_LIMIT}"

for item in staging eu-west latest; do
    log "checking ${item}"
done
