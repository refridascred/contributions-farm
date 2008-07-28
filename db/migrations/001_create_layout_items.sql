-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, level, token, score) VALUES ('strict', 89, 'legacy', 82.2);
INSERT INTO layout_items (state, level, token, score) VALUES ('legacy', 86, 'edge', 52.28);
