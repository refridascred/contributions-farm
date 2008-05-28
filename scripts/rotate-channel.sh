#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict fallback edge primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=83
log "limit is ${CHANNEL_LIMIT}"
