-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, rank, region, level) VALUES ('stable', 61, 'cached', 45);
INSERT INTO commits_records (label, rank, region, level) VALUES ('green', 18, 'open', 70);
