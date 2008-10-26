#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge staging cached eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"
