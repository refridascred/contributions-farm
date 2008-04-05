#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=392
log "limit is ${CHANNEL_LIMIT}"

for item in cached eu-west stable blue; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
