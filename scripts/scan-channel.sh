#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in latest strict local primary; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
