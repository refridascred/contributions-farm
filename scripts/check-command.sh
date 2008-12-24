#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge standard; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=429
log "limit is ${COMMAND_LIMIT}"
