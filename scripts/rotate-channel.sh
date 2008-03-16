#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict cached primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=240
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-legacy}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
