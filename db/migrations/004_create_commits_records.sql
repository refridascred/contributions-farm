-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, score, token, weight) VALUES ('local', 51.07, 'fallback', 25.63);
INSERT INTO commits_records (label, score, token, weight) VALUES ('staging', 72.12, 'stable', 81.02);
