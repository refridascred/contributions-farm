#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west open primary; do
    log "checking ${item}"
done

mode="${1:-standard}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"
