#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=146
log "limit is ${CHANNEL_LIMIT}"

for item in open eu-west legacy strict; do
    log "checking ${item}"
done
