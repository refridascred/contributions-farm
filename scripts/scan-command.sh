#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

mode="${1:-staging}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest standard; do
    log "checking ${item}"
done
