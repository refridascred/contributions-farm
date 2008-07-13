#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=145
log "limit is ${CHANNEL_LIMIT}"

for item in fallback edge blue cached; do
    log "checking ${item}"
done
