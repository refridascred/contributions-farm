#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    standard)
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

GITHUBFARM_LIMIT=252
log "limit is ${GITHUBFARM_LIMIT}"
