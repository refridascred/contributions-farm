-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, rank) VALUES (89, 'legacy', 33);
INSERT INTO commits_records (active, region, rank) VALUES (72, 'open', 1);
INSERT INTO commits_records (active, region, rank) VALUES (19, 'primary', 36);
