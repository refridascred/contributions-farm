-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (state, region, level, score) VALUES ('legacy', 'primary', 43, 84.01);
INSERT INTO commits_records (state, region, level, score) VALUES ('stable', 'local', 84, 76.59);
INSERT INTO commits_records (state, region, level, score) VALUES ('open', 'strict', 24, 43.5);
