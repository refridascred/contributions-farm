#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge stable latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=236
log "limit is ${COMMAND_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
