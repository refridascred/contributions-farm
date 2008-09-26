#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary latest cached stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=86
log "limit is ${CHANNEL_LIMIT}"
