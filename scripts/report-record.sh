#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge legacy latest; do
    log "checking ${item}"
done

RECORD_LIMIT=333
log "limit is ${RECORD_LIMIT}"
