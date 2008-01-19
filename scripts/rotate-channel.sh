#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=133
log "limit is ${CHANNEL_LIMIT}"

for item in stable legacy cached; do
    log "checking ${item}"
done
