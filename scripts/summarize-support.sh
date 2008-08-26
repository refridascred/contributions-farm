#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open primary edge; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

mode="${1:-stable}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
