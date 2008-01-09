-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, owner, count, label) VALUES ('staging', 'legacy', 24, 'fallback');
INSERT INTO commits_records (state, owner, count, label) VALUES ('open', 'fallback', 22, 'standard');
INSERT INTO commits_records (state, owner, count, label) VALUES ('cached', 'staging', 8, 'blue');
