-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, active, token, region, rank) VALUES (41.28, 17, 'green', 'blue', 24);
INSERT INTO commits_records (weight, active, token, region, rank) VALUES (46.03, 64, 'latest', 'local', 93);
