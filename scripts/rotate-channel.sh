#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=158
log "limit is ${CHANNEL_LIMIT}"

for item in latest edge blue standard; do
    log "checking ${item}"
done
