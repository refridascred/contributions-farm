#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green eu-west local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=480
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
