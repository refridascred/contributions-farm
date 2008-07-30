#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue open strict eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"
