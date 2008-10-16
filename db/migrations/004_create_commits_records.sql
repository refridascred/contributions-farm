-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, label, weight, count) VALUES (12.9, 'standard', 43.8, 93);
INSERT INTO commits_records (score, label, weight, count) VALUES (90.65, 'staging', 62.19, 55);
INSERT INTO commits_records (score, label, weight, count) VALUES (69.21, 'strict', 64.55, 49);
