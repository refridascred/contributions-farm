#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback blue staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-local}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
