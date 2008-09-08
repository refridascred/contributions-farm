-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (active, label, score, weight, region) VALUES (37, 'green', 21.22, 25.49, 'fallback');
INSERT INTO commits_records (active, label, score, weight, region) VALUES (43, 'primary', 25.23, 80.77, 'eu-west');
