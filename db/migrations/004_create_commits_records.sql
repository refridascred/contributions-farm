-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, region, count) VALUES (95, 'local', 34);
INSERT INTO commits_records (active, region, count) VALUES (24, 'green', 71);
INSERT INTO commits_records (active, region, count) VALUES (83, 'fallback', 89);
