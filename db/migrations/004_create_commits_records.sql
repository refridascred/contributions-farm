-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, region, owner, level, ratio) VALUES ('green', 'fallback', 'stable', 70, 96.18);
INSERT INTO commits_records (state, region, owner, level, ratio) VALUES ('open', 'stable', 'cached', 27, 14.13);
