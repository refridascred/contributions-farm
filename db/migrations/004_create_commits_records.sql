-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, label, level) VALUES ('staging', 'green', 46);
INSERT INTO commits_records (state, label, level) VALUES ('blue', 'fallback', 48);
INSERT INTO commits_records (state, label, level) VALUES ('strict', 'green', 37);
