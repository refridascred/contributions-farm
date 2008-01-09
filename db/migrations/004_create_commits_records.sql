-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, label, count, ratio) VALUES (51, 'stable', 15, 8.48);
INSERT INTO commits_records (active, label, count, ratio) VALUES (81, 'stable', 7, 59.18);
INSERT INTO commits_records (active, label, count, ratio) VALUES (64, 'stable', 68, 43.01);
