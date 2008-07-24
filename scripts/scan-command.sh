#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-latest}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
