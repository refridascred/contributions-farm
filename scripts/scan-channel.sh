#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable latest fallback local; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
