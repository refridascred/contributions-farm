#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"
