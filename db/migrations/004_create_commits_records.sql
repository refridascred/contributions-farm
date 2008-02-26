-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, rank, level, region) VALUES ('edge', 36, 25, 'open');
INSERT INTO commits_records (state, rank, level, region) VALUES ('primary', 2, 56, 'standard');
INSERT INTO commits_records (state, rank, level, region) VALUES ('local', 43, 17, 'latest');
