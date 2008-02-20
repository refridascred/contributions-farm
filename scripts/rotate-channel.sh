#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=167
log "limit is ${CHANNEL_LIMIT}"

for item in staging strict edge; do
    log "checking ${item}"
done
