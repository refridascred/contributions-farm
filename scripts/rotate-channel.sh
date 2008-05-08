#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard edge green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-primary}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
