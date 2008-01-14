#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-fallback}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
