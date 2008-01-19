-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, level, state, score, label) VALUES ('blue', 43, 'legacy', 71.18, 'open');
INSERT INTO commits_records (region, level, state, score, label) VALUES ('staging', 42, 'green', 50.97, 'legacy');
INSERT INTO commits_records (region, level, state, score, label) VALUES ('cached', 11, 'stable', 4.9, 'latest');
