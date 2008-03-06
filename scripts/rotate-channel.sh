#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=491
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
