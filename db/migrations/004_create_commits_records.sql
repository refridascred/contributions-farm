-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, count, region, owner, level) VALUES ('local', 65, 'latest', 'staging', 19);
INSERT INTO commits_records (label, count, region, owner, level) VALUES ('blue', 81, 'stable', 'green', 40);
