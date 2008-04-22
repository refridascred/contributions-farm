#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=321
log "limit is ${CHANNEL_LIMIT}"

for item in open stable fallback legacy; do
    log "checking ${item}"
done
