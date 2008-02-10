#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=59
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
