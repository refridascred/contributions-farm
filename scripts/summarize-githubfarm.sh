#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback open local primary; do
    log "checking ${item}"
done

GITHUBFARM_LIMIT=361
log "limit is ${GITHUBFARM_LIMIT}"
