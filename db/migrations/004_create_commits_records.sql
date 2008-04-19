-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, count, rank, region, token) VALUES ('strict', 62, 99, 'standard', 'standard');
INSERT INTO commits_records (label, count, rank, region, token) VALUES ('fallback', 9, 87, 'strict', 'staging');
INSERT INTO commits_records (label, count, rank, region, token) VALUES ('primary', 28, 91, 'local', 'legacy');
