-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, label, state, token) VALUES (73.04, 'edge', 'strict', 'local');
INSERT INTO commits_records (weight, label, state, token) VALUES (54.9, 'legacy', 'green', 'legacy');
