-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, state, level) VALUES (86, 'primary', 60);
INSERT INTO commits_records (count, state, level) VALUES (7, 'strict', 94);
INSERT INTO commits_records (count, state, level) VALUES (87, 'local', 33);
