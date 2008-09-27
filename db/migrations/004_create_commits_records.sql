-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, score, label) VALUES ('primary', 17.9, 'primary');
INSERT INTO commits_records (state, score, label) VALUES ('edge', 50.82, 'edge');
INSERT INTO commits_records (state, score, label) VALUES ('open', 14.71, 'cached');
