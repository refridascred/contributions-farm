-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, weight, rank, label, ratio) VALUES (3, 84.88, 31, 'staging', 46.94);
INSERT INTO commits_records (count, weight, rank, label, ratio) VALUES (25, 30.45, 33, 'stable', 83.22);
