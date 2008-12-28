-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, count, region) VALUES (29, 77, 'stable');
INSERT INTO commits_records (rank, count, region) VALUES (87, 71, 'cached');
INSERT INTO commits_records (rank, count, region) VALUES (9, 22, 'edge');
