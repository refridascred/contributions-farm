#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=216
log "limit is ${CHANNEL_LIMIT}"
