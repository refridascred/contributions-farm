-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, level, label) VALUES (72.99, 15, 'edge');
INSERT INTO commits_records (score, level, label) VALUES (39.62, 51, 'green');
INSERT INTO commits_records (score, level, label) VALUES (29.18, 37, 'staging');
