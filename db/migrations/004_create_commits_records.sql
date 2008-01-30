-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, state, count, ratio) VALUES ('eu-west', 71, 'eu-west', 52, 57.83);
INSERT INTO commits_records (region, active, state, count, ratio) VALUES ('local', 92, 'fallback', 46, 91.69);
