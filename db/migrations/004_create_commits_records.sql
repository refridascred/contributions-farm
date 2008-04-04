-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, region, count) VALUES (97, 'fallback', 33);
INSERT INTO commits_records (active, region, count) VALUES (36, 'standard', 42);
INSERT INTO commits_records (active, region, count) VALUES (24, 'blue', 8);
