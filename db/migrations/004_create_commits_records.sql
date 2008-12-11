-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, label, ratio, weight) VALUES (69.57, 'green', 9.98, 64.25);
INSERT INTO commits_records (score, label, ratio, weight) VALUES (42.79, 'strict', 58.12, 57.72);
INSERT INTO commits_records (score, label, ratio, weight) VALUES (59.63, 'cached', 8.09, 74.91);
