-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, level, ratio, token) VALUES ('cached', 53, 89.2, 'standard');
INSERT INTO layout_items (state, level, ratio, token) VALUES ('strict', 9, 35.44, 'fallback');
INSERT INTO layout_items (state, level, ratio, token) VALUES ('blue', 42, 89.96, 'primary');
