#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue legacy stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=289
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
