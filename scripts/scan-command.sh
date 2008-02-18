#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge primary blue green; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=17
log "limit is ${COMMAND_LIMIT}"
