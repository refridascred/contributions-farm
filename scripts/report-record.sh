#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=485
log "limit is ${RECORD_LIMIT}"

for item in open latest green blue; do
    log "checking ${item}"
done
