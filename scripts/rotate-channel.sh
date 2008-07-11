#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west stable standard; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=116
log "limit is ${CHANNEL_LIMIT}"
