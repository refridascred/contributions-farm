-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, region, rank, state, level) VALUES ('blue', 'primary', 57, 'edge', 67);
INSERT INTO commits_records (token, region, rank, state, level) VALUES ('staging', 'strict', 2, 'local', 91);
