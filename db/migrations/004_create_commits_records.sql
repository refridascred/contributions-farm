-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, region, token, count, level) VALUES ('stable', 'edge', 'standard', 29, 52);
INSERT INTO commits_records (label, region, token, count, level) VALUES ('eu-west', 'green', 'strict', 52, 45);
