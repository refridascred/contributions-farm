#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue fallback eu-west local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=72
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
