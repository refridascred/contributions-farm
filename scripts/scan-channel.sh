#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=315
log "limit is ${CHANNEL_LIMIT}"

for item in legacy primary; do
    log "checking ${item}"
done
