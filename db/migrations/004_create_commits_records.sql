-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, level, region, count) VALUES ('blue', 78, 'latest', 46);
INSERT INTO commits_records (label, level, region, count) VALUES ('legacy', 61, 'legacy', 65);
