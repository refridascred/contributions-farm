#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable primary cached edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-strict}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
