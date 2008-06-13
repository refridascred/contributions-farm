-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, level, token, state) VALUES (49.55, 58, 'strict', 'open');
INSERT INTO layout_items (ratio, level, token, state) VALUES (16.09, 2, 'edge', 'legacy');
INSERT INTO layout_items (ratio, level, token, state) VALUES (2.46, 99, 'fallback', 'standard');
