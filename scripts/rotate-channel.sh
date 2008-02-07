#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=311
log "limit is ${CHANNEL_LIMIT}"

for item in standard local blue cached; do
    log "checking ${item}"
done
