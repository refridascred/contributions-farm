#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=179
log "limit is ${CHANNEL_LIMIT}"

for item in local strict edge primary; do
    log "checking ${item}"
done
