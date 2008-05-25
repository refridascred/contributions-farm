-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, ratio, label, count) VALUES (85, 71.97, 'blue', 46);
INSERT INTO commits_records (rank, ratio, label, count) VALUES (70, 45.8, 'eu-west', 6);
