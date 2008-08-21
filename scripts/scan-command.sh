#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in fallback eu-west primary; do
    log "checking ${item}"
done

mode="${1:-stable}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
