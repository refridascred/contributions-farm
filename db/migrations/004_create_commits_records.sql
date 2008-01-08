-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, state, region, level) VALUES ('strict', 'primary', 'local', 73);
INSERT INTO commits_records (token, state, region, level) VALUES ('edge', 'eu-west', 'stable', 60);
INSERT INTO commits_records (token, state, region, level) VALUES ('stable', 'local', 'cached', 57);
