#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=204
log "limit is ${COMMAND_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
