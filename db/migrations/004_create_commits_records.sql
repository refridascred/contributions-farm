-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, state, rank) VALUES ('cached', 'legacy', 64);
INSERT INTO commits_records (label, state, rank) VALUES ('local', 'fallback', 75);
INSERT INTO commits_records (label, state, rank) VALUES ('stable', 'standard', 73);
