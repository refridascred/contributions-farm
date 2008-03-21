-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, level, count, state) VALUES ('latest', 44, 98, 'green');
INSERT INTO commits_records (token, level, count, state) VALUES ('open', 35, 94, 'green');
INSERT INTO commits_records (token, level, count, state) VALUES ('staging', 24, 38, 'legacy');
