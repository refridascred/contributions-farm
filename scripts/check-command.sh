#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=449
log "limit is ${COMMAND_LIMIT}"

mode="${1:-legacy}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge open legacy; do
    log "checking ${item}"
done
