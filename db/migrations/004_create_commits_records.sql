-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, count, owner, level, region) VALUES ('fallback', 22, 'eu-west', 19, 'legacy');
INSERT INTO commits_records (label, count, owner, level, region) VALUES ('green', 54, 'fallback', 75, 'standard');
