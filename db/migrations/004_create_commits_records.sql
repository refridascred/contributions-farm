-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, state, score, label) VALUES (23.83, 'stable', 82.63, 'primary');
INSERT INTO commits_records (ratio, state, score, label) VALUES (73.95, 'blue', 54.92, 'open');
INSERT INTO commits_records (ratio, state, score, label) VALUES (8.94, 'eu-west', 75.13, 'local');
