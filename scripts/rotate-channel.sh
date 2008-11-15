#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=411
log "limit is ${CHANNEL_LIMIT}"

for item in green eu-west open; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
