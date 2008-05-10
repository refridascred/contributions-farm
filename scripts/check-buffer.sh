#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in cached eu-west strict; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
