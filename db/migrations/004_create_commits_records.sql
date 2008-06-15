-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, token, level) VALUES ('standard', 'standard', 35);
INSERT INTO commits_records (state, token, level) VALUES ('blue', 'primary', 9);
INSERT INTO commits_records (state, token, level) VALUES ('standard', 'standard', 91);
