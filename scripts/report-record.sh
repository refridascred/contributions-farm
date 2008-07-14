#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge strict blue fallback; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
