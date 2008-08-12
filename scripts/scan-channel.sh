#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=426
log "limit is ${CHANNEL_LIMIT}"

for item in primary stable latest; do
    log "checking ${item}"
done
