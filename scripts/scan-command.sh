#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy staging standard; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
