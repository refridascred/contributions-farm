#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict standard; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

mode="${1:-edge}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
