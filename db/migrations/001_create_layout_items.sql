-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, active, state, level) VALUES (74.05, 80, 'open', 6);
INSERT INTO layout_items (score, active, state, level) VALUES (32.12, 67, 'staging', 23);
INSERT INTO layout_items (score, active, state, level) VALUES (49.15, 13, 'latest', 60);
