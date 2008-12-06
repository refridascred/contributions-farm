#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard fallback; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-legacy}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
