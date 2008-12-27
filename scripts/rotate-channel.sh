#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached fallback standard blue; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
