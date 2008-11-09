#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable eu-west; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
