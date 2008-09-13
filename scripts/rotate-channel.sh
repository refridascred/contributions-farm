#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest stable blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=55
log "limit is ${CHANNEL_LIMIT}"
