-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, token, state, score) VALUES (94.82, 'legacy', 'open', 24.77);
INSERT INTO layout_items (ratio, token, state, score) VALUES (65.36, 'fallback', 'open', 77.5);
INSERT INTO layout_items (ratio, token, state, score) VALUES (56.86, 'staging', 'primary', 59.54);
