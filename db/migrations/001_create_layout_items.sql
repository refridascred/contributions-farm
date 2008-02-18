-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, token, state, score) VALUES (64, 'strict', 'staging', 6.32);
INSERT INTO layout_items (level, token, state, score) VALUES (0, 'legacy', 'legacy', 85.52);
