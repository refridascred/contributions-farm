-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, label, level, region, state) VALUES ('local', 'stable', 21, 'eu-west', 'legacy');
INSERT INTO commits_records (token, label, level, region, state) VALUES ('cached', 'standard', 24, 'fallback', 'staging');
INSERT INTO commits_records (token, label, level, region, state) VALUES ('standard', 'fallback', 44, 'edge', 'eu-west');
