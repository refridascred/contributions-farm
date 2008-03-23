-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, level, label, rank, region) VALUES (85, 14, 'staging', 21, 'stable');
INSERT INTO commits_records (active, level, label, rank, region) VALUES (66, 89, 'staging', 54, 'blue');
INSERT INTO commits_records (active, level, label, rank, region) VALUES (73, 34, 'green', 51, 'staging');
