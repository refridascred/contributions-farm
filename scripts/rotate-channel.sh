#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=455
log "limit is ${CHANNEL_LIMIT}"

for item in edge blue open legacy; do
    log "checking ${item}"
done
