-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, weight, score, label) VALUES (77.0, 63.08, 70.75, 'green');
INSERT INTO commits_records (ratio, weight, score, label) VALUES (68.63, 68.2, 93.21, 'stable');
