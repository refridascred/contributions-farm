-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, rank) VALUES (15.35, 62);
INSERT INTO commits_records (ratio, rank) VALUES (2.51, 49);
INSERT INTO commits_records (ratio, rank) VALUES (7.75, 28);
