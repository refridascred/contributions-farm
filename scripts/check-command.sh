#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-cached}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
