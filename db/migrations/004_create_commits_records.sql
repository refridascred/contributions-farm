-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, state, region, score) VALUES (99, 'local', 'primary', 38.72);
INSERT INTO commits_records (level, state, region, score) VALUES (73, 'fallback', 'cached', 87.04);
INSERT INTO commits_records (level, state, region, score) VALUES (54, 'eu-west', 'strict', 38.5);
