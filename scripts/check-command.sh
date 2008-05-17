#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable open; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
