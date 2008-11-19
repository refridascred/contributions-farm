-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, token, level, rank) VALUES (26, 'edge', 'latest', 43, 58);
INSERT INTO commits_records (active, region, token, level, rank) VALUES (76, 'primary', 'edge', 15, 16);
