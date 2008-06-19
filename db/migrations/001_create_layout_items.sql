-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, state, weight, token) VALUES (66.23, 'primary', 79.38, 'local');
INSERT INTO layout_items (ratio, state, weight, token) VALUES (61.92, 'standard', 95.92, 'fallback');
INSERT INTO layout_items (ratio, state, weight, token) VALUES (53.1, 'standard', 91.6, 'strict');
