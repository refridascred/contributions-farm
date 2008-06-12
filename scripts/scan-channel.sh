#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy blue fallback open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-open}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
