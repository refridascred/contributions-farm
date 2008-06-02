#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=292
log "limit is ${CHANNEL_LIMIT}"

for item in fallback primary stable latest; do
    log "checking ${item}"
done
