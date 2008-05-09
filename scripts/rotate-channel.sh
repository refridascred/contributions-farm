#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green blue standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=185
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
