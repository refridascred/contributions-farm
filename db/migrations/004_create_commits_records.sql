-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, region, level, count) VALUES ('eu-west', 'local', 44, 65);
INSERT INTO commits_records (state, region, level, count) VALUES ('blue', 'open', 64, 89);
INSERT INTO commits_records (state, region, level, count) VALUES ('legacy', 'stable', 65, 3);
