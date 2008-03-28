#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-blue}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
