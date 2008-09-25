#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable blue open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-fallback}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
