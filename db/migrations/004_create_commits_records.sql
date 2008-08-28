-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, rank, label, ratio) VALUES (11.35, 63, 'green', 85.55);
INSERT INTO commits_records (weight, rank, label, ratio) VALUES (2.19, 61, 'staging', 33.71);
