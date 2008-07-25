-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, label, ratio, state) VALUES (23.43, 'local', 94.47, 'strict');
INSERT INTO commits_records (score, label, ratio, state) VALUES (85.92, 'eu-west', 48.95, 'staging');
INSERT INTO commits_records (score, label, ratio, state) VALUES (54.49, 'stable', 60.74, 'green');
