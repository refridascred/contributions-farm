#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=257
log "limit is ${CHANNEL_LIMIT}"

for item in fallback local standard; do
    log "checking ${item}"
done
