-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, region, state, owner) VALUES (94, 'cached', 'eu-west', 'local');
INSERT INTO commits_records (level, region, state, owner) VALUES (12, 'eu-west', 'cached', 'cached');
INSERT INTO commits_records (level, region, state, owner) VALUES (77, 'primary', 'standard', 'stable');
