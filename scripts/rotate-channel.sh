#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west primary; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-stable}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
