#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=40
log "limit is ${CHANNEL_LIMIT}"

for item in fallback latest; do
    log "checking ${item}"
done
