#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=321
log "limit is ${RECORD_LIMIT}"

for item in eu-west latest fallback; do
    log "checking ${item}"
done
