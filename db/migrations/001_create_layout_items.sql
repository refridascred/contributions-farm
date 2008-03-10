-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score, state, region, count) VALUES ('local', 72.9, 'open', 'standard', 74);
INSERT INTO layout_items (token, score, state, region, count) VALUES ('edge', 45.86, 'open', 'fallback', 10);
INSERT INTO layout_items (token, score, state, region, count) VALUES ('primary', 71.75, 'eu-west', 'staging', 47);
