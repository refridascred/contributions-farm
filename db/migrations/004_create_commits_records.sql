-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, label, rank, region) VALUES (82, 'local', 44, 'staging');
INSERT INTO commits_records (count, label, rank, region) VALUES (82, 'fallback', 20, 'primary');
INSERT INTO commits_records (count, label, rank, region) VALUES (0, 'blue', 47, 'eu-west');
