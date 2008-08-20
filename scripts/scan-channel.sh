#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green stable staging legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=140
log "limit is ${CHANNEL_LIMIT}"
