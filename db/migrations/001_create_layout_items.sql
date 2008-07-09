-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, state, ratio, token) VALUES (25.62, 'latest', 31.2, 'open');
INSERT INTO layout_items (weight, state, ratio, token) VALUES (25.8, 'latest', 49.44, 'fallback');
