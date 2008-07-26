-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (count, label, rank, ratio) VALUES (21, 'latest', 17, 0.22);
INSERT INTO commits_records (count, label, rank, ratio) VALUES (28, 'green', 61, 93.15);
INSERT INTO commits_records (count, label, rank, ratio) VALUES (74, 'standard', 25, 12.48);
