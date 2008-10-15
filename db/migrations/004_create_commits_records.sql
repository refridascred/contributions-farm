-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, state, count, region, score) VALUES (48, 'standard', 58, 'stable', 30.07);
INSERT INTO commits_records (level, state, count, region, score) VALUES (68, 'strict', 29, 'stable', 90.87);
INSERT INTO commits_records (level, state, count, region, score) VALUES (98, 'edge', 23, 'primary', 84.75);
