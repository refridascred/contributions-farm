-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, state, weight, token) VALUES (0, 'strict', 2.17, 'legacy');
INSERT INTO layout_items (level, state, weight, token) VALUES (12, 'legacy', 56.14, 'fallback');
