-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, count) VALUES ('primary', 67);
INSERT INTO commits_records (region, count) VALUES ('staging', 61);
INSERT INTO commits_records (region, count) VALUES ('latest', 23);
