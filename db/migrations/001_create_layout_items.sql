-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, score, count, owner, state) VALUES ('edge', 32.63, 65, 'latest', 'fallback');
INSERT INTO layout_items (region, score, count, owner, state) VALUES ('primary', 93.19, 79, 'open', 'eu-west');
INSERT INTO layout_items (region, score, count, owner, state) VALUES ('stable', 35.65, 14, 'staging', 'fallback');
