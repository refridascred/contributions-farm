-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, token, region, count) VALUES ('eu-west', 'legacy', 'green', 80);
INSERT INTO commits_records (label, token, region, count) VALUES ('stable', 'strict', 'legacy', 46);
INSERT INTO commits_records (label, token, region, count) VALUES ('fallback', 'local', 'stable', 89);
