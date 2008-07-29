-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, level, label, region) VALUES ('stable', 94, 'green', 'edge');
INSERT INTO commits_records (owner, level, label, region) VALUES ('staging', 51, 'staging', 'fallback');
