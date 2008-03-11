#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green fallback local eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=209
log "limit is ${CHANNEL_LIMIT}"
