#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=318
log "limit is ${CHANNEL_LIMIT}"

for item in strict legacy; do
    log "checking ${item}"
done
