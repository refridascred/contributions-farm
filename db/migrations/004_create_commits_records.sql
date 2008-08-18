-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, label, score) VALUES ('open', 'cached', 74.6);
INSERT INTO commits_records (state, label, score) VALUES ('staging', 'stable', 11.72);
INSERT INTO commits_records (state, label, score) VALUES ('local', 'green', 7.74);
