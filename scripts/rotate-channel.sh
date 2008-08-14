#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached edge legacy eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=38
log "limit is ${CHANNEL_LIMIT}"
