-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, state, score, label) VALUES (52.31, 'blue', 65.97, 'staging');
INSERT INTO commits_records (weight, state, score, label) VALUES (76.35, 'cached', 14.65, 'stable');
INSERT INTO commits_records (weight, state, score, label) VALUES (75.4, 'blue', 45.36, 'stable');
