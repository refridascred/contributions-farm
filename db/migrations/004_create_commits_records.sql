-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, ratio, owner, state, region) VALUES (8, 19.32, 'stable', 'open', 'eu-west');
INSERT INTO commits_records (level, ratio, owner, state, region) VALUES (24, 97.95, 'fallback', 'open', 'green');
INSERT INTO commits_records (level, ratio, owner, state, region) VALUES (39, 0.73, 'stable', 'standard', 'local');
