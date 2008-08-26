-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, region, level, score, rank) VALUES ('stable', 'stable', 38, 41.01, 68);
INSERT INTO commits_records (state, region, level, score, rank) VALUES ('local', 'fallback', 49, 82.16, 61);
INSERT INTO commits_records (state, region, level, score, rank) VALUES ('legacy', 'stable', 51, 37.34, 49);
