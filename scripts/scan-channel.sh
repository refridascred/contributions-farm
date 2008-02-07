#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=361
log "limit is ${CHANNEL_LIMIT}"

for item in staging latest; do
    log "checking ${item}"
done
