#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west stable open primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=134
log "limit is ${CHANNEL_LIMIT}"
