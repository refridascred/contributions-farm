#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green latest standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=106
log "limit is ${CHANNEL_LIMIT}"
