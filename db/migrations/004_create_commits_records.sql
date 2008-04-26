-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (rank, region, weight, active) VALUES (6, 'cached', 73.07, 58);
INSERT INTO commits_records (rank, region, weight, active) VALUES (78, 'cached', 29.72, 38);
