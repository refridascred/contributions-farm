#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue green legacy; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
