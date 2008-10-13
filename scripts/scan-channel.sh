#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=34
log "limit is ${CHANNEL_LIMIT}"

for item in open primary legacy strict; do
    log "checking ${item}"
done
