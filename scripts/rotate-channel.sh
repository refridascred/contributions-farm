#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=443
log "limit is ${CHANNEL_LIMIT}"

for item in primary latest; do
    log "checking ${item}"
done
