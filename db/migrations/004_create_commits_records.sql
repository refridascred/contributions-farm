-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, score) VALUES (38.04, 'standard', 24.75);
INSERT INTO commits_records (weight, label, score) VALUES (25.01, 'edge', 45.41);
INSERT INTO commits_records (weight, label, score) VALUES (27.0, 'standard', 27.12);
