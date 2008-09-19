#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=171
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached latest staging green; do
    log "checking ${item}"
done
