-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, label, ratio) VALUES (27, 'stable', 34.33);
INSERT INTO commits_records (count, label, ratio) VALUES (19, 'legacy', 4.78);
