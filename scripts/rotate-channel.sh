#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in standard fallback green edge; do
    log "checking ${item}"
done

mode="${1:-strict}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
