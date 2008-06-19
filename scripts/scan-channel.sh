#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=367
log "limit is ${CHANNEL_LIMIT}"

for item in open standard edge; do
    log "checking ${item}"
done
